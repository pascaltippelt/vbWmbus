/**
 * This class file was automatically generated by the AXDR compiler that is part of jDLMS (http://www.openmuc.org)
 */

package org.openmuc.jdlms.internal.asn1.cosem;

import org.openmuc.jdlms.internal.asn1.axdr.types.AxdrOctetString;

public class CosemObjectInstanceId extends AxdrOctetString {

    public static final int length = 6;

    public CosemObjectInstanceId() {
        super(length);
    }

    public CosemObjectInstanceId(byte[] octetString) {
        super(length, octetString);
    }

}
