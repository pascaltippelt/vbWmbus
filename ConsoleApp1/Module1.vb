﻿Imports System.Runtime.CompilerServices
Imports System.Text
Imports Newtonsoft.Json

Public Enum DataValueType
    _Long
    _Double
    _Date
    _String
    BCD
    General
End Enum
Public Enum FunctionField
    Valore_Istantaneo
    Valore_Massimo
    Valore_Minimo
    Valore_Errore
End Enum
Public Enum Description
    ENERGY
    VOLUME
    MASS
    ON_TIME
    OPERATING_TIME
    POWER
    VOLUME_FLOW
    VOLUME_FLOW_EXT
    MASS_FLOW
    FLOW_TEMPERATURE
    RETURN_TEMPERATURE
    TEMPERATURE_DIFFERENCE
    EXTERNAL_TEMPERATURE
    PRESSURE
    DDATE
    DATE_TIME
    VOLTAGE
    CURRENT
    AVERAGING_DURATION
    ACTUALITY_DURATION
    FABRICATION_NO
    MODEL_VERSION
    PARAMETER_SET_ID
    HARDWARE_VERSION
    FIRMWARE_VERSION
    ERROR_FLAGS
    CUSTOMER
    RESERVED
    OPERATING_TIME_BATTERY
    RF_LEVEL
    HCA
    REACTIVE_ENERGY
    TEMPERATURE_LIMIT
    MAX_POWER
    REACTIVE_POWER
    REL_HUMIDITY
    FREQUENCY
    PHASE
    EXTENDED_IDENTIFICATION
    ADDRESS
    NOT_SUPPORTED
    MANUFACTURER_SPECIFIC
    FUTURE_VALUE
    USER_DEFINED
    APPARENT_ENERGY
    CUSTOMER_LOCATION
    ACCESS_CODE_OPERATOR
    ACCESS_CODE_USER
    PASSWORD
    ACCESS_CODE_SYSTEM_DEVELOPER
    OTHER_SOFTWARE_VERSION
    ACCESS_CODE_SYSTEM_OPERATOR
    ERROR_MASK
    SECURITY_KEY
    DIGITAL_INPUT
    BAUDRATE
    DIGITAL_OUTPUT
    RESPONSE_DELAY_TIME
    RETRY
    FIRST_STORAGE_NUMBER_CYCLIC
    REMOTE_CONTROL
    LAST_STORAGE_NUMBER_CYCLIC
    SIZE_STORAGE_BLOCK
    STORAGE_INTERVALL
    TARIF_START
    DURATION_LAST_READOUT
    TIME_POINT
    TARIF_DURATION
    OPERATOR_SPECIFIC_DATA
    TARIF_PERIOD
    NUMBER_STOPS
    LAST_CUMULATION_DURATION
    SPECIAL_SUPPLIER_INFORMATION
    PARAMETER_ACTIVATION_STATE
    CONTROL_SIGNAL
    WEEK_NUMBER
    DAY_OF_WEEK
    REMAINING_BATTERY_LIFE_TIME
    TIME_POINT_DAY_CHANGE
    CUMULATION_COUNTER
    RESET_COUNTER

End Enum
Public Enum DeviceType
    OTHER = &H0
    OIL_METER = &H1
    ELECTRICITY_METER = &H2
    GAS_METER = &H3
    HEAT_METER = &H4
    STEAM_METER = &H5
    WARM_WATER_METER = &H6
    WATER_METER = &H7
    HEAT_COST_ALLOCATOR = &H8
    COMPRESSED_AIR = &H9
    COOLING_METER_OUTLET = &HA
    COOLING_METER_INLET = &HB
    HEAT_METER_INLET = &HC
    HEAT_COOLING_METER = &HD
    BUS_SYSTEM_COMPONENT = &HE
    UNKNOWN = &HF
    RESERVED_FOR_METER_16 = &H10
    RESERVED_FOR_METER_17 = &H11
    RESERVED_FOR_METER_18 = &H12
    RESERVED_FOR_METER_19 = &H13
    CALORIFIC_VALUE = &H14
    HOT_WATER_METER = &H15
    COLD_WATER_METER = &H16
    DUAL_REGISTER_WATER_METER = &H17
    PRESSURE_METER = &H18
    AD_CONVERTER = &H19
    SMOKE_DETECTOR = &H1A
    ROOM_SENSOR_TEMP_HUM = &H1B
    GAS_DETECTOR = &H1C
    RESERVED_FOR_SENSOR_H1D = &H1D
    RESERVED_FOR_SENSOR_H1E = &H1E
    RESERVED_FOR_SENSOR_H1F = &H1F
    BREAKER_ELEC = &H20
    VALVE_GAS_OR_WATER = &H21
    RESERVED_FOR_SWITCHING_DEVICE_H22 = &H22
    RESERVED_FOR_SWITCHING_DEVICE_H23 = &H23
    RESERVED_FOR_SWITCHING_DEVICE_H24 = &H24
    CUSTOMER_UNIT_DISPLAY_DEVICE = &H25
    RESERVED_FOR_CUSTOMER_UNIT_H26 = &H26
    RESERVED_FOR_CUSTOMER_UNIT_H27 = &H27
    WASTE_WATER_METER = &H28
    GARBAGE = &H29
    RESERVED_FOR_CO2 = &H2A
    RESERVED_FOR_ENV_METER_H2B = &H2B
    RESERVED_FOR_ENV_METER_H2C = &H2C
    RESERVED_FOR_ENV_METER_H2D = &H2D
    RESERVED_FOR_ENV_METER_H2E = &H2E
    RESERVED_FOR_ENV_METER_H2F = &H2F
    RESERVED_FOR_SYSTEM_DEVICES_H30 = &H30
    COM_CONTROLLER = &H31
    UNIDIRECTION_REPEATER = &H32
    BIDIRECTION_REPEATER = &H33
    RESERVED_FOR_SYSTEM_DEVICES_H34 = &H34
    RESERVED_FOR_SYSTEM_DEVICES_H35 = &H35
    RADIO_CONVERTER_SYSTEM_SIDE = &H36
    RADIO_CONVERTER_METER_SIDE = &H37
    RESERVED_FOR_SYSTEM_DEVICES_H38 = &H38
    RESERVED_FOR_SYSTEM_DEVICES_H39 = &H39
    RESERVED_FOR_SYSTEM_DEVICES_H3A = &H3A
    RESERVED_FOR_SYSTEM_DEVICES_H3B = &H3B
    RESERVED_FOR_SYSTEM_DEVICES_H3C = &H3C
    RESERVED_FOR_SYSTEM_DEVICES_H3D = &H3D
    RESERVED_FOR_SYSTEM_DEVICES_H3E = &H3E
    RESERVED_FOR_SYSTEM_DEVICES_H3F = &H3F
    RESERVED = &HFF
End Enum
Public Enum DlmsUnit

    YEAR = 1 ''"a")'
    MONTH = 2 ' "mo")'
    WEEK = 3 ' "wk")'
    DAY = 4 ' "d")'
    HOUR = 5 ' "h")'
    MIN = 6 ' "min")'
    SECOND = 7 ' "s")'
    DEGREE = 8 ' "°")'
    DEGREE_CELSIUS = 9 ' "°C")'
    CURRENCY = 10 ' "")'
    METRE = 11 ' "m")'
    METRE_PER_SECOND = 12 ' "m/s")'
    CUBIC_METRE = 13 ' "m³")'
    CUBIC_METRE_CORRECTED = 14 ' "m³")'
    CUBIC_METRE_PER_HOUR = 15 ' "m³/h")'
    CUBIC_METRE_PER_HOUR_CORRECTED = 16 ' "m³/h")'
    CUBIC_METRE_PER_DAY = 17 ' "m³/d")'
    CUBIC_METRE_PER_DAY_CORRECTED = 18 ' "m³/d")'
    LITRE = 19 ' "l")'
    KILOGRAM = 20 ' "kg")'
    NEWTON = 21 ' "N")'
    NEWTONMETER = 22 ' "Nm")'
    PASCAL = 23 ' "Pa")'
    BAR = 24 ' "bar")'
    JOULE = 25 ' "J")'
    JOULE_PER_HOUR = 26 ' "J/h")'
    WATT = 27 ' "W")'
    VOLT_AMPERE = 28 ' "VA")'
    VAR = 29 ' "var")'
    WATT_HOUR = 30 ' "Wh")'
    VOLT_AMPERE_HOUR = 31 ' "VAh")'
    VAR_HOUR = 32 ' "varh")'
    AMPERE = 33 ' "A")'
    COULOMB = 34 ' "C")'
    VOLT = 35 ' "V")'
    VOLT_PER_METRE = 36 ' "V/m")'
    FARAD = 37 ' "F")'
    OHM = 38 ' "Ohm")'
    OHM_METRE = 39 ' "Ohm m²/m")'
    WEBER = 40 ' "Wb")'
    TESLA = 41 ' "T")'
    AMPERE_PER_METRE = 42 ' "A/m")'
    HENRY = 43 ' "H")'
    HERTZ = 44 ' "Hz")'
    ACTIVE_ENERGY_METER_CONSTANT_OR_PULSE_VALUE = 45 ' "1/=Wh)")'
    REACTIVE_ENERGY_METER_CONSTANT_OR_PULSE_VALUE = 46 ' "1/=varh)")'
    APPARENT_ENERGY_METER_CONSTANT_OR_PULSE_VALUE = 47 ' "1=VAh)")'
    VOLT_SQUARED_HOURS = 48 ' "V²h")'
    AMPERE_SQUARED_HOURS = 49 ' "A²h")'
    KILOGRAM_PER_SECOND = 50 ' "kg/s")'
    SIEMENS = 51 ' "S")'
    KELVIN = 52 ' "K")'
    VOLT_SQUARED_HOUR_METER_CONSTANT_OR_PULSE_VALUE = 53 ' "1/=V²h)")'
    AMPERE_SQUARED_HOUR_METER_CONSTANT_OR_PULSE_VALUE = 54 ' "1/=A²h)")'
    METER_CONSTANT_OR_PULSE_VALUE = 55 ' "1/m³")'
    PERCENTAGE = 56 ' "%")'
    AMPERE_HOUR = 57 ' "Ah")'
    ENERGY_PER_VOLUME = 60 ' "Wh/m³")'
    CALORIFIC_VALUE = 61 ' "J/m³")'
    MOLE_PERCENT = 62 ' "Mol %")'
    MASS_DENSITY = 63 ' "g/m³")'
    PASCAL_SECOND = 64 ' "Pa s")'
    SPECIFIC_ENERGY = 65 ' "J/kg")'
    SIGNAL_STRENGTH = 70 ' "dBm")'
    SIGNAL_STRENGTH_MICROVOLT = 71 ' "dBµv")'
    LOGARITHMIC = 72 ' "dB")'
    RESERVED = 253 ' "")'
    OTHER_UNIT = 254 ' "other")'
    COUNT = 255 ' "count")'
    CUBIC_METRE_PER_SECOND = 150 ' "m³/s")'
    CUBIC_METRE_PER_MINUTE = 151 ' "m³/min")'
    KILOGRAM_PER_HOUR = 152 ' "kg/h")'
    CUBIC_FEET = 153 ' "cft")'
    US_GALLON = 154 ' "Impl. gal.")'
    US_GALLON_PER_MINUTE = 155 ' "Impl. gal./min")'
    US_GALLON_PER_HOUR = 156 ' "Impl. gal./h")'
    DEGREE_FAHRENHEIT = 157 ' "°F");
End Enum
Public Enum EncryptionMode As Integer
    NONE = 0
    AES_128 = 1
    DES_CBC = 2
    DES_CBC_IV = 3
    RESERVED_04 = 4
    AES_CBC_IV = 5
    RESERVED_06 = 6
    AES_CBC_IV_0 = 7
    RESERVED_08 = 8
    RESERVED_09 = 9
    RESERVED_10 = 10
    RESERVED_11 = 11
    RESERVED_12 = 12
    TLS = 13
    RESERVED_14 = 14
    RESERVED_15 = 15
End Enum


Module Module1
    Private m_functionField As FunctionField
    Private m_description As Description
    Private userDefinedDescription As String
    Private unit As DlmsUnit
    Private multiplierExponent As Integer = 0
    Private dateTypeF As Boolean = False
    Private dateTypeG As Boolean = False
    ' // Data Information Block that contains a DIF and optionally up to 10 DIFEs
    Private dib() As Byte
    ' // Value Information Block that contains a VIF and optionally up to 10 VIFEs
    Private vib() As Byte
    Private dataValue As Object
    Private m_dataValueType As DataValueType
    ' max is 41 bits
    Private tariff As Integer
    ' max 20 bits
    Private subunit As Long
    Private dataLength As Integer
    Private storageNumber As Long
    Dim calendar As DateTime
    Dim DecodedData As New DecodedDeviceClass
    Private manufacturerId As String
    Private manufacturerDetails As String
    Private deviceId As String
    Private version As Integer
    Private deviceType As String


    Sub Main()
        '                           0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9
        Dim telegramma As String = "5044243434398583000D7A8C0000202F2F046D262D5B2B0406000000008410060000000001FD1710041303000000043B00000000042B00000000025B1700025F18000261EDFF03FD0C05000002FD0B30110000000"
        'Dim telegramma As String = "204472341111111101077A000010852F2F000102030405060708090A0B0C0D0E0F9976"
        'Dim telegramma As String = "2E44B05C10000000021B7AC40820052F2F0A6699010AFB1A930202FD971D01002F2F2F2F2F2F2F2F2F2F2F2F2F879E0D0A"

        '


        Dim i As Integer = 0
        Dim buffer As Byte() = {}
        Dim j As Integer = 0

        For j = 0 To telegramma.Length / 2 - 1
            Array.Resize(buffer, buffer.Length + 1)
            buffer(j) = Convert.ToInt16(Strings.Mid(telegramma, j * 2 + 1, 2), 16)
        Next

        decodePreamble(buffer)

        Dim offset = telegramma.IndexOf("2F2F") / 2 + 1 ' 16



        While i < telegramma.Length And i < buffer.Length - 5
            i = offset + 1

                decodeDib(buffer, i)
                Dim dataField As Integer = buffer(i) And &HF
                dataLength = dataField
                storageNumber = (buffer(i) And &H40) \ 2 ^ 6

                subunit = 0
                tariff = 0
                Dim numDife As Integer = 0


                While ((buffer(i + 1) And 128) = 128)
                    i += 1
                    subunit = subunit + (((buffer(i) And &H40) \ 2 ^ 6) * 2 ^ numDife)
                    tariff = tariff + ((buffer(i) And &H30) \ 2 ^ 4) * 2 ^ (numDife * 2)
                    storageNumber = storageNumber + ((buffer(i) And 15) * 2 ^ ((numDife * 4) + 1))
                    numDife = (numDife + 1)

                End While

                unit = 0
                multiplierExponent = 0

                dib = CopyofRange(buffer, offset + 1, i + 1)


                i = i + 1
                Dim vif As Integer = (buffer(i) And 255)
                Dim decodeFurtherVifs As Boolean = False

                If (vif = 251) Then
                    decodeAlternateExtendedVif(buffer(i))
                    If ((buffer(i) And 128) = 128) Then
                        decodeFurtherVifs = True
                    End If

                    i += 1 'verificare
                ElseIf ((vif And 127) = 124) Then
                    i = (i + decodeUserDefinedVif(buffer, i))
                    If ((vif And 128) = 128) Then
                        decodeFurtherVifs = True
                    End If

                ElseIf (vif = 253) Then
                    decodeMainExtendedVif(buffer(i))
                    If ((buffer(i) And 128) = 128) Then
                        decodeFurtherVifs = True
                    End If

                    i += 1 'verificare
                Else
                    decodeMainVif(vif)
                    If ((vif And 128) = 128) Then
                        decodeFurtherVifs = True
                    End If

                End If
                vib = CopyofRange(buffer, offset + dib.Length + 1, i + 1)

                Select Case (dataField)
                    Case 0, 8
                        dataValue = Nothing
                        m_dataValueType = DataValueType.General
                    Case 1
                        dataValue = CLng(buffer(i = i + 1))
                        m_dataValueType = DataValueType._Long
                    Case 2
                        If dateTypeG Then
                            Dim day As Integer = (31 And buffer(i))
                            i = i + 1
                            Dim year1 As Integer = ((224 And buffer(i)) \ 2 ^ 5)
                            Dim month As Integer = (15 And buffer(i))
                            i = i + 1
                            Dim year2 As Integer = ((240 And buffer(i)) \ 2 ^ 1)
                            Dim year As Integer = (2000 + (year1 + year2))
                            Dim calendar As DateTime = New DateTime(year, (month - 1), day, 0, 0, 0)
                            dataValue = calendar.TimeOfDay
                            m_dataValueType = DataValueType._Date
                        Else
                            i = i + 1
                            dataValue = CLng(((buffer(i) And 255) Or ((buffer(i + 1) And 255) * 256)))
                            If dataValue > 32768 Then
                                dataValue = dataValue - 65535
                            End If
                            i = i + 1
                            m_dataValueType = DataValueType._Long
                        End If

                    Case 3
                        If ((buffer((i + 2)) And 128) = 128) Then
                            ' negative
                            dataValue = CLng((buffer(i + 1) And 255) Or
                        ((buffer(i + 2) And 255) * 256) Or
                        ((buffer(i + 3) And 255) * 65536) Or 255 * 2 ^ 24)
                            i = i + 3
                        Else
                            dataValue = CLng(((buffer(i + 1) And 255) Or
                        (((buffer(i + 2) And 255) * 256) Or
                        ((buffer(i + 3) And 255) * 65536))))
                            i = i + 3
                        End If

                        m_dataValueType = DataValueType._Long
                    Case 4
                        If dateTypeF Then
                            i = i + 1
                            Dim min As Integer = (buffer(i) And 63)
                            Dim hour As Integer = (buffer(i) And 31)
                            i = i + 1
                            Dim yearh As Integer = ((96 And buffer(i)) \ 2 ^ 5)
                            Dim day As Integer = (buffer(i) And 31)
                            i = i + 1
                            Dim year1 As Integer = ((224 And buffer(i)) \ 2 ^ 5)
                            Dim mon As Integer = (buffer(i) And 15)
                            i = i + 1
                            Dim year2 As Integer = ((240 And buffer(i)) \ 2 ^ 1)
                            If (yearh = 0) Then
                                yearh = 1
                            End If
                            If mon = 0 Then mon = 1
                            If day = 0 Then day = 1

                            Dim year As Integer = 1900 + 100 * yearh + year1 + year2
                            calendar = New DateTime(year, mon - 1, day, hour, min, 0)
                            dataValue = calendar.TimeOfDay
                            m_dataValueType = DataValueType._Date
                        Else
                            i = i + 1
                            dataValue = CLng((buffer(i) And 255) Or
                        ((buffer(i + 1) And 255) * 256) Or
                        ((buffer(i + 2) And 255) * 65536) Or ((buffer(i + 3) And 255) * 2 ^ 24))
                            i = i + 3
                            m_dataValueType = DataValueType._Long
                        End If

                    Case 5
                'Dim doubleDatavalue As Double = ByteBuffer.wrap(buffer, i, 4).order(ByteOrder.LITTLE_ENDIAN).getFloat
                'i = (i + 4)
                'dataValue = CDbl(doubleDatavalue)
                'm_dataValueType = DataValueType._DOUBLE
                    Case 6
                        If ((buffer((i + 5)) And 128) = 128) Then
                            ' negative
                            i = i + 1
                            dataValue = CLng((buffer(i) And 255) Or
                        (((buffer(i + 1) And 255) * 256)) Or
                        (((buffer(i + 2) And 255) * 2 ^ 16)) Or
                        (((buffer(i + 3) And 255) * 2 ^ 24)) Or
                        (((CType(buffer(i + 4), Long) And 255) * 2 ^ 32)) Or
                        (((CType(buffer(i + 5), Long) And 255) * 2 ^ 40)) Or (255 * 2 ^ 48) Or (256 << 56))
                            i = i + 5
                        Else
                            i = i + 1
                            dataValue = CLng(((buffer(i) And 255) Or
                        (((buffer(i + 1) And 255) * 256) Or
                        (((buffer(i + 2) And 255) * 65536) Or
                        (((buffer(i + 3) And 255) * 2 ^ 24) Or
                        (((CType(buffer(i + 4), Long) And 255) * 2 ^ 32) Or
                        ((CType(buffer(i + 5), Long) And 255) * 2 ^ 40)))))))
                            i = i + 5
                        End If

                        m_dataValueType = DataValueType._Long
                    Case 7
                        dataValue = CLng(((buffer(i = i + 1) And 255) Or (((buffer(i = i + 1) And 255) + 8) _
                                Or (((buffer(i = i + 1) And 255) + 16) _
                                Or (((buffer(i = i + 1) And 255) + 24) _
                                Or (((CType(buffer(i = i + 1), Long) And 255) + 32) _
                                Or (((CType(buffer(i = i + 1), Long) And 255) + 40) _
                                Or (((CType(buffer(i = i + 1), Long) And 255) + 48) _
                                Or ((CType(buffer(i = i + 1), Long) And 255) + 56)))))))))
                        m_dataValueType = DataValueType._Long
                    Case 9
                        i = setBCD(buffer, i, 1)
                    Case 10
                        i = setBCD(buffer, i, 2)
                    Case 11
                        i = setBCD(buffer, i, 3)
                    Case 12
                        i = setBCD(buffer, i, 4)
                    Case 14
                        i = setBCD(buffer, i, 6)
                    Case 13
                        Dim variableLength As Integer = (buffer(i + 1) And 255)
                        i = i + 1
                        Dim dataLength0x0d As Integer
                        If (variableLength < 192) Then
                            dataLength0x0d = variableLength
                        ElseIf ((variableLength >= 192) AndAlso (variableLength <= 201)) Then
                            dataLength0x0d = (2 * (variableLength - 192))
                        ElseIf ((variableLength >= 208) AndAlso (variableLength <= 217)) Then
                            dataLength0x0d = (2 * (variableLength - 208))
                        ElseIf ((variableLength >= 224) AndAlso (variableLength <= 239)) Then
                            dataLength0x0d = (variableLength - 224)
                        ElseIf (variableLength = 248) Then
                            dataLength0x0d = 4
                        Else
                            Throw New Exception(("Unsupported LVAR Field: " + variableLength))
                        End If


                        Dim rawData() As Byte = New Byte((dataLength0x0d) - 1) {}
                        For k = 0 To dataLength0x0d - 1
                            rawData(k) = buffer(i + dataLength0x0d - 1 - k)
                            k = (k + 1)
                        Next

                        i = (i + dataLength0x0d)
                        dataValue = System.Text.Encoding.Default.GetString(rawData)
                        m_dataValueType = DataValueType._String
                    Case Else
                        Dim msg As String = String.Format("Unknown Data Field in DIF: " & dataField.ToString)
                        Throw New Exception(msg)
                End Select

                If dataValue Is Nothing Then
                    dataValue = 0
                End If
                Dim DataX As String = ""
                If IsNumeric(dataValue) Then
                    DataX = Format(dataValue * 10 ^ multiplierExponent, "###0.##")
                ElseIf TypeOf (dataValue) Is Byte() Then
                    If dataValue.length = 1 Then
                        Dim temp As Integer
                        Integer.TryParse(Hex(dataValue(0)), temp)
                        DataX = Format(temp * 10 ^ multiplierExponent, "###0.##")
                    ElseIf dataValue.length = 2 Then
                        Dim temp As Integer
                        Integer.TryParse(Hex(dataValue(1)) & Hex(dataValue(0)), temp)
                        DataX = Format(temp * 10 ^ multiplierExponent, "###0.##")
                    ElseIf dataValue.length = 3 Then
                        Dim temp As Integer
                        Integer.TryParse(Hex(dataValue(2)) & Hex(dataValue(1)) & Hex(dataValue(0)), temp)
                        DataX = Format(temp * 10 ^ multiplierExponent, "###0.##")
                    ElseIf dataValue.length = 4 Then
                        Dim temp As Integer
                        Integer.TryParse(Hex(dataValue(3)) & Hex(dataValue(2)) & Hex(dataValue(1)) & Hex(dataValue(0)), temp)
                        DataX = Format(temp * 10 ^ multiplierExponent, "###0.##")

                    End If
                Else
                    DataX = dataValue.ToString
                End If
                If TypeOf (dataValue) Is TimeSpan Then
                    DataX = calendar.ToString
                End If

                dateTypeF = False
                dateTypeG = False

                Dim aggiungi As Integer
                If TypeOf (dataValue) Is Byte() Then
                    aggiungi = dataValue.length
                Else
                    aggiungi = dataField
                End If

                offset = offset + dib.Length + vib.Length + aggiungi


                Array.Resize(DecodedData.DecodedDataField, DecodedData.DecodedDataField.Length + 1)
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).calendar = calendar
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).datavalue = dataValue
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).multiplierexponent = multiplierExponent
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).m_datavaluetype = m_dataValueType
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).m_description = m_description
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).m_functionField = m_functionField
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).storagenumber = storageNumber
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).subunit = subunit
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).tariff = tariff
                DecodedData.DecodedDataField(DecodedData.DecodedDataField.Length - 1).unit = unit
                DecodedData.manufacturerId = manufacturerId
                DecodedData.manufacturerDetails = manufacturerDetails
                DecodedData.deviceId = deviceId
                DecodedData.version = version
                DecodedData.deviceType = deviceType

                calendar = New DateTime
                dataValue = ""
                multiplierExponent = 0
                m_dataValueType = 0
                m_description = 0
                m_functionField = 0
                storageNumber = 0
                subunit = 0
                tariff = 0
            End While


salta:
        Dim json As String = JsonConvert.SerializeObject(DecodedData)
        Console.WriteLine(json)
        Console.ReadKey()

    End Sub
    Private Sub decodePreamble(ByVal buffer As Byte())

        Dim bais As Byte() = CopyofRange(buffer, 0, 16)
        'Me.hashCode = Arrays.hashCode(Me.bytes)
        Try
            deviceId = decodeDeviceId(bais)
            manufacturerId = decodeManufacturerId(bais)
            manufacturerDetails = selectManufacturerDetailsClass.selectManufacturerDetails(manufacturerId)

            version = (bais(8) And 255)
            deviceType = [Enum].GetName(GetType(DeviceType), bais(9) And 255)

        Catch e As Exception
            ' should not occur
            Throw New Exception(e.Message)
        End Try
    End Sub
    Private Function decodeDeviceId(ByVal bais As Byte()) As String
        Dim idArray As String = Hex(bais(7)).ToString.PadLeft(2, "0") & Hex(bais(6)).ToString.PadLeft(2, "0") &
            Hex(bais(5)).ToString.PadLeft(2, "0") & Hex(bais(4)).ToString.PadLeft(2, "0")
        Return idArray
    End Function
    Private Function decodeManufacturerId(ByVal bais As Byte()) As String
        Dim manufacturerIdAsInt As Integer = ((bais(2) And 255) + (bais(3) * 256))
        Dim c As Char = ChrW((manufacturerIdAsInt And 31) + 64)
        manufacturerIdAsInt = (manufacturerIdAsInt \ 2 ^ 5)
        Dim c1 As Char = ChrW((manufacturerIdAsInt And 31) + 64)
        manufacturerIdAsInt = (manufacturerIdAsInt \ 2 ^ 5)
        Dim c2 As Char = ChrW((manufacturerIdAsInt And 31) + 64)
        Dim sb As New StringBuilder
        Return sb.Append(c2).Append(c1).Append(c).ToString
    End Function
    Private Function decodeUserDefinedVif(ByVal buffer() As Byte, ByVal offset As Integer) As Integer
        Dim length As Integer = buffer(offset)
        Dim sb As StringBuilder = New StringBuilder
        Dim i As Integer = (offset + length)
        Do While (i > offset)
            sb.Append(buffer(i).ToString)
            i = (i - 1)
        Loop

        m_description = Description.USER_DEFINED
        userDefinedDescription = sb.ToString
        Return (length + 1)
    End Function
    Private Sub decodeMainVif(ByVal vif As Integer)
        m_description = Description.NOT_SUPPORTED
        If ((vif And 64) = 0) Then
            decodeE0(vif)
        Else
            decodeE1(vif)
        End If

    End Sub
    Private Sub decodeMainExtendedVif(ByVal vif As Byte)
        If ((vif And 127) = 11) Then
            ' E000 1011
            m_description = Description.PARAMETER_SET_ID
        ElseIf ((vif And 127) = 12) Then
            ' E000 1100
            m_description = Description.MODEL_VERSION
        ElseIf ((vif And 127) = 13) Then
            ' E000 1101
            m_description = Description.HARDWARE_VERSION
        ElseIf ((vif And 127) = 14) Then
            ' E000 1110
            m_description = Description.FIRMWARE_VERSION
        ElseIf ((vif And 127) = 15) Then
            ' E000 1111
            m_description = Description.OTHER_SOFTWARE_VERSION
        ElseIf ((vif And 127) = 16) Then
            ' E001 0000
            m_description = Description.CUSTOMER_LOCATION
        ElseIf ((vif And 127) = 17) Then
            ' E001 0001
            m_description = Description.CUSTOMER
        ElseIf ((vif And 127) = 18) Then
            ' E001 0010
            m_description = Description.ACCESS_CODE_USER
        ElseIf ((vif And 127) = 19) Then
            ' E001 0011
            m_description = Description.ACCESS_CODE_OPERATOR
        ElseIf ((vif And 127) = 20) Then
            ' E001 0100
            m_description = Description.ACCESS_CODE_SYSTEM_OPERATOR
        ElseIf ((vif And 127) = 21) Then
            ' E001 0101
            m_description = Description.ACCESS_CODE_SYSTEM_DEVELOPER
        ElseIf ((vif And 127) = 22) Then
            ' E001 0110
            m_description = Description.PASSWORD
        ElseIf ((vif And 127) = 23) Then
            ' E001 0111
            m_description = Description.ERROR_FLAGS
        ElseIf ((vif And 127) = 24) Then
            ' E001 1000
            m_description = Description.ERROR_MASK
        ElseIf ((vif And 127) = 25) Then
            ' E001 1001
            m_description = Description.SECURITY_KEY
        ElseIf ((vif And 127) = 26) Then
            ' E001 1010
            m_description = Description.DIGITAL_OUTPUT
        ElseIf ((vif And 127) = 27) Then
            ' E001 1011
            m_description = Description.DIGITAL_INPUT
        ElseIf ((vif And 127) = 28) Then
            ' E001 1100
            m_description = Description.BAUDRATE
        ElseIf ((vif And 127) = 29) Then
            ' E001 1101
            m_description = Description.RESPONSE_DELAY_TIME
        ElseIf ((vif And 127) = 30) Then
            ' E001 1110
            m_description = Description.RETRY
        ElseIf ((vif And 127) = 31) Then
            ' E001 1111
            m_description = Description.REMOTE_CONTROL
        ElseIf ((vif And 127) = 32) Then
            ' E010 0000
            m_description = Description.FIRST_STORAGE_NUMBER_CYCLIC
        ElseIf ((vif And 127) = 33) Then
            ' E010 0001
            m_description = Description.LAST_STORAGE_NUMBER_CYCLIC
        ElseIf ((vif And 127) = 34) Then
            ' E010 0010
            m_description = Description.SIZE_STORAGE_BLOCK
        ElseIf ((vif And 127) = 35) Then
            ' E010 0011
            m_description = Description.RESERVED
        ElseIf ((vif And 124) = 36) Then
            ' E010 01nn
            m_description = Description.STORAGE_INTERVALL
            unit = timeUnitFor(vif)
        ElseIf ((vif And 127) = 40) Then
            ' E010 1000
            m_description = Description.STORAGE_INTERVALL
            unit = DlmsUnit.MONTH
        ElseIf ((vif And 127) = 41) Then
            ' E010 1001
            m_description = Description.STORAGE_INTERVALL
            unit = DlmsUnit.YEAR
        ElseIf ((vif And 127) = 42) Then
            ' E010 1010
            m_description = Description.OPERATOR_SPECIFIC_DATA
        ElseIf ((vif And 127) = 43) Then
            ' E010 1011
            m_description = Description.TIME_POINT
            unit = DlmsUnit.SECOND
        ElseIf ((vif And 124) = 44) Then
            ' E010 11nn
            m_description = Description.DURATION_LAST_READOUT
            unit = timeUnitFor(vif)
        ElseIf ((vif And 124) = 48) Then
            ' E011 00nn
            m_description = Description.TARIF_DURATION
            unit = timeUnitFor(vif)
        ElseIf ((vif And 124) = 52) Then
            ' E011 01nn
            m_description = Description.TARIF_PERIOD
            unit = timeUnitFor(vif)
        ElseIf ((vif And 127) = 56) Then
            ' E011 1000
            m_description = Description.TARIF_PERIOD
            unit = DlmsUnit.MONTH
        ElseIf ((vif And 127) = 57) Then
            ' E011 1001
            m_description = Description.TARIF_PERIOD
            unit = DlmsUnit.YEAR
        ElseIf ((vif And 112) = 64) Then
            ' E100 0000
            m_description = Description.VOLTAGE
            multiplierExponent = ((vif And 15) - 9)
            unit = DlmsUnit.VOLT
        ElseIf ((vif And 112) = 80) Then
            ' E101 0000
            m_description = Description.CURRENT
            multiplierExponent = ((vif And 15) - 12)
            unit = DlmsUnit.AMPERE
        ElseIf ((vif And 127) = 96) Then
            ' E110 0000
            m_description = Description.RESET_COUNTER
        ElseIf ((vif And 127) = 97) Then
            ' E110 0001
            m_description = Description.CUMULATION_COUNTER
        ElseIf ((vif And 127) = 98) Then
            ' E110 0010
            m_description = Description.CONTROL_SIGNAL
        ElseIf ((vif And 127) = 99) Then
            ' E110 0011
            m_description = Description.DAY_OF_WEEK
            ' 1 = Monday; 7 = Sunday; 0 = all Days
        ElseIf ((vif And 127) = 100) Then
            ' E110 0100
            m_description = Description.WEEK_NUMBER
        ElseIf ((vif And 127) = 101) Then
            ' E110 0101
            m_description = Description.TIME_POINT_DAY_CHANGE
        ElseIf ((vif And 127) = 102) Then
            ' E110 0110
            m_description = Description.PARAMETER_ACTIVATION_STATE
        ElseIf ((vif And 127) = 103) Then
            ' E110 0111
            m_description = Description.SPECIAL_SUPPLIER_INFORMATION
        ElseIf ((vif And 124) = 104) Then
            ' E110 10nn
            m_description = Description.LAST_CUMULATION_DURATION
            unit = unitBiggerFor(vif)
        ElseIf ((vif And 124) = 108) Then
            ' E110 11nn
            m_description = Description.OPERATING_TIME_BATTERY
            unit = unitBiggerFor(vif)
        ElseIf ((vif And 127) = 112) Then
            ' E111 0000
            m_description = Description.NOT_SUPPORTED
            ' TODO: BATTERY_CHANGE_DATE_TIME
        ElseIf ((vif And 127) = 113) Then
            ' E111 0001
            m_description = Description.RF_LEVEL
            unit = DlmsUnit.SIGNAL_STRENGTH
        ElseIf ((vif And 127) = 114) Then
            ' E111 0010
            m_description = Description.NOT_SUPPORTED
            ' TODO: DAYLIGHT_SAVING (begin, ending, deviation)
        ElseIf ((vif And 127) = 115) Then
            ' E111 0011
            m_description = Description.NOT_SUPPORTED
            ' TODO: Listening window management data type L
        ElseIf ((vif And 127) = 116) Then
            ' E111 0100
            m_description = Description.REMAINING_BATTERY_LIFE_TIME
            unit = DlmsUnit.DAY
        ElseIf ((vif And 127) = 117) Then
            ' E111 0101
            m_description = Description.NUMBER_STOPS
        ElseIf ((vif And 127) = 118) Then
            ' E111 0110
            m_description = Description.MANUFACTURER_SPECIFIC
        ElseIf ((vif And 127) >= 119) Then
            ' E111 0111 - E111 1111
            m_description = Description.RESERVED
        Else
            m_description = Description.NOT_SUPPORTED
        End If
    End Sub
    Private Sub decodeAlternateExtendedVif(ByVal vif As Byte)
        m_description = Description.NOT_SUPPORTED
        ' default value
        If ((vif And 64) = 0) Then
            ' E0
            If ((vif And 32) = 0) Then
                ' E00
                If ((vif And 16) = 0) Then
                    ' E000
                    If ((vif And 8) = 0) Then
                        ' E000 0
                        If ((vif And 4) = 0) Then
                            ' E000 00
                            If ((vif And 2) = 0) Then
                                ' E000 000
                                m_description = Description.ENERGY
                                multiplierExponent = (5 + (vif And 1))
                                unit = DlmsUnit.WATT_HOUR
                            Else
                                ' E000 001
                                m_description = Description.REACTIVE_ENERGY
                                multiplierExponent = (3 + (vif And 1))
                                unit = DlmsUnit.VAR_HOUR
                            End If

                        Else
                            ' E000 01
                            If ((vif And 2) = 0) Then
                                ' E000 010
                                m_description = Description.APPARENT_ENERGY
                                multiplierExponent = (3 + (vif And 1))
                                unit = DlmsUnit.VOLT_AMPERE_HOUR
                            Else
                                ' E000 011
                                m_description = Description.NOT_SUPPORTED
                            End If

                        End If

                    Else
                        ' E000 1
                        If ((vif And 4) = 0) Then
                            ' E000 10
                            If ((vif And 2) = 0) Then
                                ' E000 100
                                m_description = Description.ENERGY
                                multiplierExponent = (8 + (vif And 1))
                                unit = DlmsUnit.JOULE
                            Else
                                ' E000 101
                                m_description = Description.NOT_SUPPORTED
                            End If

                        Else
                            ' E000 11
                            m_description = Description.ENERGY
                            multiplierExponent = (5 + (vif And 3))
                            unit = DlmsUnit.CALORIFIC_VALUE
                        End If

                    End If

                Else
                    ' E001
                    If ((vif And 8) = 0) Then
                        ' E001 0
                        If ((vif And 4) = 0) Then
                            ' E001 00
                            If ((vif And 2) = 0) Then
                                ' E001 000
                                m_description = Description.VOLUME
                                multiplierExponent = (2 + (vif And 1))
                                unit = DlmsUnit.CUBIC_METRE
                            Else
                                ' E001 001
                                m_description = Description.NOT_SUPPORTED
                            End If

                        Else
                            ' E001 01
                            m_description = Description.REACTIVE_POWER
                            multiplierExponent = (vif And 3)
                            unit = DlmsUnit.VAR
                        End If

                    Else
                        ' E001 1
                        If ((vif And 4) = 0) Then
                            ' E001 10
                            If ((vif And 2) = 0) Then
                                ' E001 100
                                m_description = Description.MASS
                                multiplierExponent = (5 + (vif And 1))
                                unit = DlmsUnit.KILOGRAM
                            Else
                                ' E001 101
                                m_description = Description.REL_HUMIDITY
                                multiplierExponent = (-1 + (vif And 1))
                                unit = DlmsUnit.PERCENTAGE
                            End If

                        Else
                            ' E001 11
                            m_description = Description.NOT_SUPPORTED
                        End If

                    End If

                End If

            Else
                ' E01
                If ((vif And 16) = 0) Then
                    ' E010
                    If ((vif And 8) = 0) Then
                        ' E010 0
                        If ((vif And 4) = 0) Then
                            ' E010 00
                            If ((vif And 2) = 0) Then
                                ' E010 000
                                If ((vif And 1) = 0) Then
                                    ' E010 0000
                                    m_description = Description.VOLUME
                                    multiplierExponent = 0
                                    unit = DlmsUnit.CUBIC_FEET
                                Else
                                    ' E010 0001
                                    m_description = Description.VOLUME
                                    multiplierExponent = -1
                                    unit = DlmsUnit.CUBIC_FEET
                                End If

                            Else
                                ' E010 001
                                ' outdated value !
                                m_description = Description.VOLUME
                                multiplierExponent = (-1 + (vif And 1))
                                unit = DlmsUnit.US_GALLON
                            End If

                        Else
                            ' E010 01
                            If ((vif And 2) = 0) Then
                                ' E010 010
                                If ((vif And 1) = 0) Then
                                    ' E010 0100
                                    ' outdated value !
                                    m_description = Description.VOLUME_FLOW
                                    multiplierExponent = -3
                                    unit = DlmsUnit.US_GALLON_PER_MINUTE
                                Else
                                    ' E010 0101
                                    ' outdated value !
                                    m_description = Description.VOLUME_FLOW
                                    multiplierExponent = 0
                                    unit = DlmsUnit.US_GALLON_PER_MINUTE
                                End If

                            Else
                                ' E010 011
                                If ((vif And 1) = 0) Then
                                    ' E010 0110
                                    ' outdated value !
                                    m_description = Description.VOLUME_FLOW
                                    multiplierExponent = 0
                                    unit = DlmsUnit.US_GALLON_PER_HOUR
                                Else
                                    ' E010 0111
                                    m_description = Description.NOT_SUPPORTED
                                End If

                            End If

                        End If

                    Else
                        ' E010 1
                        If ((vif And 4) = 0) Then
                            ' E010 10
                            If ((vif And 2) = 0) Then
                                ' E010 100
                                m_description = Description.POWER
                                multiplierExponent = (5 + (vif And 1))
                                unit = DlmsUnit.WATT
                            Else
                                If ((vif And 1) = 0) Then
                                    ' E010 1010
                                    m_description = Description.PHASE
                                    multiplierExponent = -1
                                    ' is -1 or 0 correct ??
                                    unit = DlmsUnit.DEGREE
                                End If

                                ' TODO same
                                ' else {
                                ' // E010 1011
                                ' description = Description.PHASE;
                                ' multiplierExponent = -1; // is -1 or 0 correct ??
                                ' unit = DlmsUnits.DlmsUnit.DEGREE;
                                ' }
                            End If

                        Else
                            ' E010 11
                            m_description = Description.FREQUENCY
                            multiplierExponent = (-3 + (vif And 3))
                            unit = DlmsUnit.HERTZ
                        End If

                    End If

                Else
                    ' E011
                    If ((vif And 8) = 0) Then
                        ' E011 0
                        If ((vif And 4) = 0) Then
                            ' E011 00
                            If ((vif And 2) = 0) Then
                                ' E011 000
                                m_description = Description.POWER
                                multiplierExponent = (8 + (vif And 1))
                                unit = DlmsUnit.JOULE_PER_HOUR
                            Else
                                ' E011 001
                                m_description = Description.NOT_SUPPORTED
                            End If

                        Else
                            ' E011 01
                            m_description = Description.APPARENT_ENERGY
                            multiplierExponent = (vif And 3)
                            unit = DlmsUnit.VOLT_AMPERE
                        End If

                    Else
                        ' E011 1
                        m_description = Description.NOT_SUPPORTED
                    End If

                End If

            End If

        Else
            ' E1
            If ((vif And 32) = 0) Then
                ' E10
                If ((vif And 16) = 0) Then
                    ' E100
                    m_description = Description.NOT_SUPPORTED
                Else
                    ' E101
                    If ((vif And 8) = 0) Then
                        ' E101 0
                        m_description = Description.NOT_SUPPORTED
                    Else
                        ' E101 1
                        If ((vif And 4) = 0) Then
                            ' E101 10
                            ' outdated value !
                            m_description = Description.FLOW_TEMPERATURE
                            multiplierExponent = ((vif And 3) - 3)
                            unit = DlmsUnit.DEGREE_FAHRENHEIT
                        Else
                            ' E101 11
                            ' outdated value !
                            m_description = Description.RETURN_TEMPERATURE
                            multiplierExponent = ((vif And 3) - 3)
                            unit = DlmsUnit.DEGREE_FAHRENHEIT
                        End If

                    End If

                End If

            Else
                ' E11
                If ((vif And 16) = 0) Then
                    ' E110
                    If ((vif And 8) = 0) Then
                        ' E110 0
                        If ((vif And 4) = 0) Then
                            ' E110 00
                            ' outdated value !
                            m_description = Description.TEMPERATURE_DIFFERENCE
                            multiplierExponent = ((vif And 3) - 3)
                            unit = DlmsUnit.DEGREE_FAHRENHEIT
                        Else
                            ' E110 01
                            ' outdated value !
                            m_description = Description.FLOW_TEMPERATURE
                            multiplierExponent = ((vif And 3) - 3)
                            unit = DlmsUnit.DEGREE_FAHRENHEIT
                        End If

                    Else
                        ' E110 1
                        m_description = Description.NOT_SUPPORTED
                    End If

                Else
                    ' E111
                    If ((vif And 8) = 0) Then
                        ' E111 0
                        If ((vif And 4) = 0) Then
                            ' E111 00
                            ' outdated value !
                            m_description = Description.TEMPERATURE_LIMIT
                            multiplierExponent = ((vif And 3) - 3)
                            unit = DlmsUnit.DEGREE_FAHRENHEIT
                        Else
                            ' E111 01
                            m_description = Description.TEMPERATURE_LIMIT
                            multiplierExponent = ((vif And 3) - 3)
                            unit = DlmsUnit.DEGREE_CELSIUS
                        End If

                    Else
                        ' E111 1
                        m_description = Description.MAX_POWER
                        multiplierExponent = ((vif And 7) - 3)
                        unit = DlmsUnit.WATT
                    End If

                End If

            End If

        End If

    End Sub
    Private Sub decodeDib(ByVal buffer() As Byte, ByVal i As Integer)

        Dim ff As Integer = ((buffer(i) And &H30) \ 2 ^ 4)
        Select Case ff
            Case 0
                m_functionField = FunctionField.Valore_Istantaneo
            Case 1
                m_functionField = FunctionField.Valore_Massimo
            Case 2
                m_functionField = FunctionField.Valore_Minimo
            Case 3
                m_functionField = FunctionField.Valore_Errore
            Case Else
                m_functionField = Nothing
        End Select

    End Sub
    Private Sub decodeE1(ByVal vif As Integer)
        ' E1
        If ((vif And 32) = 0) Then
            decodeE10(vif)
        Else
            decodeE11(vif)
        End If

    End Sub
    Private Sub decodeE0(ByVal vif As Integer)
        ' E0
        If ((vif And 32) = 0) Then
            decodeE00(vif)
        Else
            decode01(vif)
        End If

    End Sub
    Private Function timeUnitFor(ByVal vif As Byte) As DlmsUnit
        Dim u As Integer = (vif And 3)
        Select Case (u)
            Case 0
                ' E010 1100
                Return DlmsUnit.SECOND
            Case 1
                ' E010 1101
                Return DlmsUnit.MIN
            Case 2
                ' E010 1110
                Return DlmsUnit.HOUR
            Case 3
                ' E010 1111
                Return DlmsUnit.DAY
            Case Else
                Throw New Exception(String.Format("Unknown unit 0x%02X.", u))
        End Select

    End Function
    Private Function unitBiggerFor(ByVal vif As Byte) As DlmsUnit
        Dim u As Integer = (vif And 3)
        Select Case (u)
            Case 0
                ' E110 1100
                Return DlmsUnit.HOUR
            Case 1
                ' E110 1101
                Return DlmsUnit.DAY
            Case 2
                ' E110 1110
                Return DlmsUnit.MONTH
            Case 3
                ' E110 1111
                Return DlmsUnit.YEAR
            Case Else
                Throw New Exception(String.Format("Unknown unit 0x%02X.", u))
        End Select

    End Function
    Private Sub decodeE11(ByVal vif As Integer)
        ' E11
        If ((vif And 16) = 0) Then
            decodeE110(vif)
        Else
            decodeE111(vif)
        End If

    End Sub
    Private Sub decodeE10(ByVal vif As Integer)
        ' E10
        If ((vif And 16) = 0) Then
            ' E100
            If ((vif And 8) = 0) Then
                ' E100 0
                m_description = Description.VOLUME_FLOW_EXT
                multiplierExponent = ((vif And 7) - 7)
                unit = DlmsUnit.CUBIC_METRE_PER_MINUTE
            Else
                ' E100 1
                m_description = Description.VOLUME_FLOW_EXT
                multiplierExponent = ((vif And 7) - 9)
                unit = DlmsUnit.CUBIC_METRE_PER_SECOND
            End If

        Else
            ' E101
            If ((vif And 8) = 0) Then
                ' E101 0
                m_description = Description.MASS_FLOW
                multiplierExponent = ((vif And 7) - 3)
                unit = DlmsUnit.KILOGRAM_PER_HOUR
            Else
                ' E101 1
                If ((vif And 4) = 0) Then
                    ' E101 10
                    m_description = Description.FLOW_TEMPERATURE
                    multiplierExponent = ((vif And 3) - 3)
                    unit = DlmsUnit.DEGREE_CELSIUS
                Else
                    ' E101 11
                    m_description = Description.RETURN_TEMPERATURE
                    multiplierExponent = ((vif And 3) - 3)
                    unit = DlmsUnit.DEGREE_CELSIUS
                End If

            End If

        End If

    End Sub
    Private Sub decode01(ByVal vif As Integer)
        ' E01
        If ((vif And 16) = 0) Then
            ' E010
            If ((vif And 8) = 0) Then
                ' E010 0
                If ((vif And 4) = 0) Then
                    ' E010 00
                    m_description = Description.ON_TIME
                Else
                    ' E010 01
                    m_description = Description.OPERATING_TIME
                End If

                decodeTimeUnit(vif)
            Else
                ' E010 1
                m_description = Description.POWER
                multiplierExponent = ((vif And 7) - 3)
                unit = DlmsUnit.WATT
            End If

        Else
            ' E011
            If ((vif And 8) = 0) Then
                ' E011 0
                m_description = Description.POWER
                multiplierExponent = (vif And 7)
                unit = DlmsUnit.JOULE_PER_HOUR
            Else
                ' E011 1
                m_description = Description.VOLUME_FLOW
                multiplierExponent = ((vif And 7) - 6)
                unit = DlmsUnit.CUBIC_METRE_PER_HOUR
            End If

        End If

    End Sub
    Private Sub decodeE00(ByVal vif As Integer)
        ' E00
        If ((vif And 16) = 0) Then
            ' E000
            If ((vif And 8) = 0) Then
                ' E000 0
                m_description = Description.ENERGY
                multiplierExponent = ((vif And 7) - 3)
                unit = DlmsUnit.WATT_HOUR
            Else
                ' E000 1
                m_description = Description.ENERGY
                multiplierExponent = (vif And 7)
                unit = DlmsUnit.JOULE
            End If

        Else
            ' E001
            If ((vif And 8) = 0) Then
                ' E001 0
                m_description = Description.VOLUME
                multiplierExponent = ((vif And 7) - 6)
                unit = DlmsUnit.CUBIC_METRE
            Else
                ' E001 1
                m_description = Description.MASS
                multiplierExponent = ((vif And 7) - 3)
                unit = DlmsUnit.KILOGRAM
            End If

        End If

    End Sub
    Private Sub decodeE111(ByVal vif As Integer)
        ' E111
        If ((vif And 8) = 0) Then
            ' E111 0
            If ((vif And 4) = 0) Then
                m_description = Description.AVERAGING_DURATION
            Else
                m_description = Description.ACTUALITY_DURATION
            End If

            decodeTimeUnit(vif)
        Else
            ' E111 1
            If ((vif And 4) = 0) Then
                ' E111 10
                If ((vif And 2) = 0) Then
                    ' E111 100
                    If ((vif And 1) = 0) Then
                        ' E111 1000
                        m_description = Description.FABRICATION_NO
                    Else
                        ' E111 1001
                        m_description = Description.EXTENDED_IDENTIFICATION
                    End If

                Else
                    ' E111 101
                    If ((vif And 1) = 0) Then
                        m_description = Description.ADDRESS
                    Else
                        ' E111 1011
                        ' Codes used with extension indicator 0xFB (table 29 of DIN EN 13757-3:2011)
                        Throw New Exception("Trying to decode a mainVIF even though it is an alternate extended vif")
                    End If

                End If

            Else
                ' E111 11
                If ((vif And 2) = 0) Then
                    ' E111 110
                    If ((vif And 1) = 0) Then
                        ' E111 1100
                        ' Extension indicator 0xFC: VIF is given in following string
                        m_description = Description.NOT_SUPPORTED
                    Else
                        ' E111 1101
                        ' Extension indicator 0xFD: main VIFE-code extension table (table 28 of DIN EN
                        ' 13757-3:2011)
                        Throw New Exception("Trying to decode a mainVIF even though it is a main extended vif")
                    End If

                Else
                    ' E111 111
                    If ((vif And 1) = 0) Then
                        ' E111 1110
                        m_description = Description.FUTURE_VALUE
                    Else
                        ' E111 1111
                        m_description = Description.MANUFACTURER_SPECIFIC
                    End If

                End If

            End If

        End If

    End Sub
    Private Sub decodeE110(ByVal vif As Integer)
        ' E110
        If ((vif And 8) = 0) Then
            ' E110 0
            If ((vif And 4) = 0) Then
                ' E110 00
                m_description = Description.TEMPERATURE_DIFFERENCE
                multiplierExponent = ((vif And 3) - 3)
                unit = DlmsUnit.KELVIN
            Else
                ' E110 01
                m_description = Description.EXTERNAL_TEMPERATURE
                multiplierExponent = ((vif And 3) - 3)
                unit = DlmsUnit.DEGREE_CELSIUS
            End If

        Else
            ' E110 1
            If ((vif And 4) = 0) Then
                ' E110 10
                m_description = Description.PRESSURE
                multiplierExponent = ((vif And 3) - 3)
                unit = DlmsUnit.BAR
            Else
                ' E110 11
                If ((vif And 2) = 0) Then
                    ' E110 110
                    If ((vif And 1) = 0) Then
                        ' E110 1100
                        m_description = Description.DDATE
                        dateTypeG = True
                    Else
                        ' E110 1101
                        m_description = Description.DATE_TIME
                        dateTypeF = True
                    End If

                Else
                    ' E110 111
                    If ((vif And 1) = 0) Then
                        ' E110 1110
                        m_description = Description.HCA
                        unit = DlmsUnit.RESERVED
                    Else
                        m_description = Description.NOT_SUPPORTED
                    End If

                End If

            End If

        End If

    End Sub
    Private Sub decodeTimeUnit(ByVal vif As Integer)
        If ((vif And 2) = 0) Then
            If ((vif And 1) = 0) Then
                unit = DlmsUnit.SECOND
            Else
                unit = DlmsUnit.MIN
            End If

        ElseIf ((vif And 1) = 0) Then
            unit = DlmsUnit.HOUR
        Else
            unit = DlmsUnit.DAY
        End If

    End Sub
    Public Function CopyofRange(ByVal arra As Byte(), FromCopy As Integer, ToCopy As Integer) As Byte()
        Dim arrb As Byte() = {}
        Array.Resize(arrb, ToCopy - FromCopy)
        Array.Copy(arra, FromCopy, arrb, 0, ToCopy - FromCopy)
        Return arrb
    End Function
    Private Function setBCD(ByVal buffer() As Byte, ByVal i As Integer, ByVal j As Integer) As Integer
        dataValue = CopyofRange(buffer, i + 1, (i + j + 1))
        m_dataValueType = DataValueType.BCD
        Return (i + j)
    End Function
    Public Function getUnit(ByVal i As Integer) As String

        Dim value As String = String.Empty

        Select Case i
            Case DlmsUnit.YEAR
                value = "a"
            Case DlmsUnit.MONTH
                value = "mo"
            Case DlmsUnit.WEEK
                value = "wk"
            Case DlmsUnit.DAY
                value = "d"
            Case DlmsUnit.HOUR
                value = "h"
            Case DlmsUnit.MIN
                value = "min"
            Case DlmsUnit.SECOND
                value = "s"
            Case DlmsUnit.DEGREE
                value = "°"
            Case DlmsUnit.DEGREE_CELSIUS
                value = "°C"
            Case DlmsUnit.CURRENCY
                value = String.Empty
            Case DlmsUnit.METRE
                value = "m"
            Case DlmsUnit.METRE_PER_SECOND
                value = "m/s"
            Case DlmsUnit.CUBIC_METRE
                value = "m³"
            Case DlmsUnit.CUBIC_METRE_CORRECTED
                value = "m³"
            Case DlmsUnit.CUBIC_METRE_PER_HOUR
                value = "m³/h"
            Case DlmsUnit.CUBIC_METRE_PER_HOUR_CORRECTED
                value = "m³/h"
            Case DlmsUnit.CUBIC_METRE_PER_DAY
                value = "m³/d"
            Case DlmsUnit.CUBIC_METRE_PER_DAY_CORRECTED
                value = "m³/d"
            Case DlmsUnit.LITRE
                value = "l"
            Case DlmsUnit.KILOGRAM
                value = "kg"
            Case DlmsUnit.NEWTON
                value = "N"
            Case DlmsUnit.NEWTONMETER
                value = "Nm"
            Case DlmsUnit.PASCAL
                value = "Pa"
            Case DlmsUnit.BAR
                value = "bar"
            Case DlmsUnit.JOULE
                value = "J"
            Case DlmsUnit.JOULE_PER_HOUR
                value = "J/h"
            Case DlmsUnit.WATT
                value = "W"
            Case DlmsUnit.VOLT_AMPERE
                value = "VA"
            Case DlmsUnit.VAR
                value = "var"
            Case DlmsUnit.WATT_HOUR
                value = "Wh"
            Case DlmsUnit.VOLT_AMPERE_HOUR
                value = "VAh"
            Case DlmsUnit.VAR_HOUR
                value = "varh"
            Case DlmsUnit.AMPERE
                value = "A"
            Case DlmsUnit.COULOMB
                value = "C"
            Case DlmsUnit.VOLT
                value = "V"
            Case DlmsUnit.VOLT_PER_METRE
                value = "V/m"
            Case DlmsUnit.FARAD
                value = "F"
            Case DlmsUnit.OHM
                value = "Ohm"
            Case DlmsUnit.OHM_METRE
                value = "Ohm m²/m"
            Case DlmsUnit.WEBER
                value = "Wb"
            Case DlmsUnit.TESLA
                value = "T"
            Case DlmsUnit.AMPERE_PER_METRE
                value = "A/m"
            Case DlmsUnit.HENRY
                value = "H"
            Case DlmsUnit.HERTZ
                value = "Hz"
            Case DlmsUnit.ACTIVE_ENERGY_METER_CONSTANT_OR_PULSE_VALUE
                value = "1/=Wh"
            Case DlmsUnit.REACTIVE_ENERGY_METER_CONSTANT_OR_PULSE_VALUE
                value = "1/=varh"
            Case DlmsUnit.APPARENT_ENERGY_METER_CONSTANT_OR_PULSE_VALUE
                value = "1=VAh"
            Case DlmsUnit.VOLT_SQUARED_HOURS
                value = "V²h"
            Case DlmsUnit.AMPERE_SQUARED_HOURS
                value = "A²h"
            Case DlmsUnit.KILOGRAM_PER_SECOND
                value = "kg/s"
            Case DlmsUnit.SIEMENS
                value = "S"
            Case DlmsUnit.KELVIN
                value = "K"
            Case DlmsUnit.VOLT_SQUARED_HOUR_METER_CONSTANT_OR_PULSE_VALUE
                value = "1/=V²h)"
            Case DlmsUnit.AMPERE_SQUARED_HOUR_METER_CONSTANT_OR_PULSE_VALUE
                value = "1/=A²h"
            Case DlmsUnit.METER_CONSTANT_OR_PULSE_VALUE
                value = "1/m³"
            Case DlmsUnit.PERCENTAGE
                value = "%"
            Case DlmsUnit.AMPERE_HOUR
                value = "Ah"
            Case DlmsUnit.ENERGY_PER_VOLUME
                value = "Wh/m³"
            Case DlmsUnit.CALORIFIC_VALUE
                value = "J/m³"
            Case DlmsUnit.MOLE_PERCENT
                value = "Mol %"
            Case DlmsUnit.MASS_DENSITY
                value = "g/m³"
            Case DlmsUnit.PASCAL_SECOND
                value = "Pa s"
            Case DlmsUnit.SPECIFIC_ENERGY
                value = "J/kg"
            Case DlmsUnit.SIGNAL_STRENGTH
                value = "dBm"
            Case DlmsUnit.SIGNAL_STRENGTH_MICROVOLT
                value = "dBµv"
            Case DlmsUnit.LOGARITHMIC
                value = "dB"
            Case DlmsUnit.RESERVED
                value = ""
            Case DlmsUnit.OTHER_UNIT
                value = "other"
            Case DlmsUnit.COUNT
                value = "count"
            Case DlmsUnit.CUBIC_METRE_PER_SECOND
                value = "m³/s"
            Case DlmsUnit.CUBIC_METRE_PER_MINUTE
                value = "m³/min"
            Case DlmsUnit.KILOGRAM_PER_HOUR
                value = "kg/h"
            Case DlmsUnit.CUBIC_FEET
                value = "cft"
            Case DlmsUnit.US_GALLON
                value = "Impl. gal."
            Case DlmsUnit.US_GALLON_PER_MINUTE
                value = "Impl. gal./min"
            Case DlmsUnit.US_GALLON_PER_HOUR
                value = "Impl. gal./h"
            Case DlmsUnit.DEGREE_FAHRENHEIT
                value = "°F"

        End Select

        Return value
    End Function

End Module
Public Class DecodedDeviceClass
    Public Property manufacturerId As String
    Public Property manufacturerDetails As String
    Public Property deviceId As String
    Public Property version As Integer
    Public Property deviceType As String
    Public DecodedDataField As DecodedDataFields() = {}
    Public Sub New()
        Me.manufacturerId = ""
        Me.manufacturerDetails = ""
        Me.deviceId = ""
        Me.version = 0
        Me.deviceType = ""
    End Sub
End Class
Public Structure DecodedDataFields
    Public m_description As Description
    Public m_functionField As FunctionField
    Public subunit As Long
    Public tariff As Integer
    Public storagenumber As Long
    Public calendar As DateTime
    Public datavalue As Object
    Public m_datavaluetype As DataValueType
    Public unit As DlmsUnit
    Public ReadOnly Property unitSymbol As String
        Get
            Return getUnit(Me.unit)
        End Get
    End Property
    Public Property multiplierexponent As Integer
End Structure
