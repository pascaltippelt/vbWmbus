/**
 * This class file was automatically generated by the AXDR compiler that is part of jDLMS (http://www.openmuc.org)
 */

package org.openmuc.jdlms.internal.asn1.cosem;

import java.io.IOException;
import java.io.InputStream;

import org.openmuc.jasn1.ber.BerTag;
import org.openmuc.jasn1.ber.ReverseByteArrayOutputStream;
import org.openmuc.jasn1.ber.types.BerBitString;

public class Conformance extends BerBitString {

    public static final BerTag identifier = new BerTag(BerTag.APPLICATION_CLASS, BerTag.PRIMITIVE, 31);

    public Conformance() {
    }

    public Conformance(byte[] bitString, int numBits) {
        if ((numBits <= (((bitString.length - 1) * 8) + 1)) || (numBits > (bitString.length * 8))) {
            throw new IllegalArgumentException("numBits out of bound.");
        }

        this.value = bitString;
        this.numBits = numBits;
    }

    public int encode(ReverseByteArrayOutputStream revOStream) throws IOException {
        return encode(revOStream, false) + identifier.encode(revOStream);
    }

    @Override
    public int decode(InputStream iStream) throws IOException {
        return identifier.decodeAndCheck(iStream) + decode(iStream, false);
    }

}