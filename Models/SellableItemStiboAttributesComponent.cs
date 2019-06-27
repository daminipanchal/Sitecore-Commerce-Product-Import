using Sitecore.Commerce.Core;
using System;
using System.ComponentModel.DataAnnotations;
namespace LX.Plugin.ImportSellableItems.Models
{
    /// <summary>
    /// The SellableItemStiboAttributesComponent.
    /// </summary>
    public class SellableItemStiboAttributesComponent : Component
    {

        [Display(Name = "Feature Bullets 1")]
        public string Feature_Bullets_1 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 2")]
        public string Feature_Bullets_2 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 3")]
        public string Feature_Bullets_3 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 4")]
        public string Feature_Bullets_4 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 5")]
        public string Feature_Bullets_5 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 6")]
        public string Feature_Bullets_6 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 7")]
        public string Feature_Bullets_7 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 8")]
        public string Feature_Bullets_8 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 9")]
        public string Feature_Bullets_9 { get; set; } = string.Empty;

        [Display(Name = "Feature Bullets 10")]
        public string Feature_Bullets_10 { get; set; } = string.Empty;

        [Display(Name = "Drininking Chilled Water")]
        public string Drininking_Chilled_Water_YN { get; set; } = string.Empty;

        [Display(Name = "Drinking Hot Water")]
        public string Drinking_Hot_Water_YN { get; set; } = string.Empty;

        [Display(Name = "Drinking Water Dispenser")]
        public string Drinking_Water_Dispenser_YN { get; set; } = string.Empty;

        [Display(Name = "Toilet Seat Width Inside")]
        public string Toilet_Seat_Width_Inside { get; set; } = string.Empty;

        [Display(Name = "Toilet Seat Length Inside")]
        public string Toilet_Seat_Length_Inside { get; set; } = string.Empty;

        [Display(Name = "Tub Drain Opening Size")]
        public string Tub_Drain_Opening_Size { get; set; } = string.Empty;

        [Display(Name = "Tub Shower Base Threshold")]
        public string Tub_Shower_Base_Threshold_Height { get; set; } = string.Empty;

        [Display(Name = "Vanity Cabinet Depth")]
        public string Vanity_Cabinet_Depth { get; set; } = string.Empty;

        [Display(Name = "Vanity Cabinet Height")]
        public string Vanity_Cabinet_Height { get; set; } = string.Empty;

        [Display(Name = "Vanity Cabinet Width")]
        public string Vanity_Cabinet_Width { get; set; } = string.Empty;

        [Display(Name = "Vanity Assembled Width")]
        public string Vanity_Assembled_Width { get; set; } = string.Empty;

        [Display(Name = "Vanity Assembled Depth")]
        public string Vanity_Assembled_Depth { get; set; } = string.Empty;

        [Display(Name = "Vanity Assembled Height")]
        public string Vanity_Assembled_Height { get; set; } = string.Empty;

        [Display(Name = "Vanity Assembled Weight")]
        public string Vanity_Assembled_Weight { get; set; } = string.Empty;


        [Display(Name = "Tub Depth")]
        public string Tub_Depth { get; set; } = string.Empty;

        [Display(Name = "Tub Overflow Height")]
        public string Tub_Overflow_Height { get; set; } = string.Empty;

        [Display(Name = "Tub Water Depth")]
        public string Tub_Water_Depth { get; set; } = string.Empty;

        [Display(Name = "Height")]
        public string Product_Height { get; set; } = string.Empty;

        [Display(Name = "Weight")]
        public string Product_Weight { get; set; } = string.Empty;

        [Display(Name = "Length")]
        public string Product_Length { get; set; } = string.Empty;

        [Display(Name = "Widht")]
        public string Product_Width { get; set; } = string.Empty;

        [Display(Name = "Hazard Class Number")]
        public string Hazard_Class_Number { get; set; } = string.Empty;

        [Display(Name = "Hazmat")]
        public string Hazmat_YN { get; set; } = string.Empty;

        [Display(Name = "OMRD")]
        public string ORMD_YN { get; set; } = string.Empty;

        [Display(Name = "UN NA Number")]
        public string UN_NA_Number { get; set; } = string.Empty;

        [Display(Name = "NFPA Storage Classification")]
        public string NFPA_Storage_Classification { get; set; } = string.Empty;

        [Display(Name = "UNSPSC Code United Nations Code")]
        public string UNSPSC_Code_United_Nations_Code { get; set; } = string.Empty;


        [Display(Name = "Shower Wall Type")]
        public string Shower_Wall_Type { get; set; } = string.Empty;

        [Display(Name = "Shower Bath Product Type")]
        public string Shower_Bath_Product_Type { get; set; } = string.Empty;

        [Display(Name = "Valve Type")]
        public string Valve_Type { get; set; } = string.Empty;

        [Display(Name = "Shower System Product Type")]
        public string Shower_System_Product_Type { get; set; } = string.Empty;

        [Display(Name = "Water Efficient")]
        public string Water_Efficient_YN { get; set; } = string.Empty;

        [Display(Name = "Pull Down")]
        public string Pull_Down_YN { get; set; } = string.Empty;

        [Display(Name = "Fitting Features")]
        public string Fitting_Features { get; set; } = string.Empty;

        [Display(Name = "Foot Operation")]
        public string Foot_Operation_YN { get; set; } = string.Empty;

        [Display(Name = "Faucet Type")]
        public string Fitting_Touchless_Touch_On { get; set; } = string.Empty;


        [Display(Name = "Temperature Control")]
        public string Temperature_Control_YN { get; set; } = string.Empty;

        [Display(Name = "Side Spray")]
        public string Side_Spray_YN { get; set; } = string.Empty;


        [Display(Name = "Massachusetts Plumbing Board")]
        public string Massachusetts_Plumbing_Board_YN { get; set; } = string.Empty;

        [Display(Name = "UL Listed")]
        public string Certification_CAN_UL { get; set; } = string.Empty;

        [Display(Name = "Smoke and Flame Compliant")]
        public string Smoke_And_Flame_Compliant { get; set; } = string.Empty;

        [Display(Name = "Proposition 65 Disclosure")]
        public string Proposition_65_Disclosure_YN { get; set; } = string.Empty;

        [Display(Name = "WaterSense")]
        public string EPA_Watersense_YN { get; set; } = string.Empty;

        [Display(Name = "Certifications")]
        public string Certification_UL { get; set; } = string.Empty;

        [Display(Name = "CEC Certified")]
        public string CEC_Certified_YN { get; set; } = string.Empty;

        [Display(Name = "Certification NSF")]
        public string Certification_NSF { get; set; } = string.Empty;

        [Display(Name = "CALGreen")]
        public string Cal_Green_YN { get; set; } = string.Empty;


        [Display(Name = "ADA")]
        public string ADA_YN { get; set; } = string.Empty;

        [Display(Name = "Barrier Free")]
        public string Barrier_Free { get; set; } = string.Empty;

        [Display(Name = "Drain Material")]
        public string Drain_Material { get; set; } = string.Empty;

        [Display(Name = "Drain Included")]
        public string Drain_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Item Shape - Base")]
        public string Item_Shape { get; set; } = string.Empty;

        [Display(Name = "Base Threshold")]
        public int Base_Threshold { get; set; } = 0;

        [Display(Name = "Installation")]
        public string Concealed_Or_Exposed_Flush_Valve { get; set; } = string.Empty;

        [Display(Name = "Finish Type - Door Glass")]
        public string Door_Glass_Finish { get; set; } = string.Empty;

        [Display(Name = "Each Weight Gross Weight SAP")]
        public double Each_Weight_Gross_Weight_SAP { get; set; } = 0;

        [Display(Name = "SKU Status")]
        public string Distribution_Status_SAP { get; set; } = string.Empty;

        [Display(Name = "Base UOM SAP")]
        public string Base_UOM_SAP { get; set; } = string.Empty;

        [Display(Name = "Number of Items")]
        public int AltUOMConvFac { get; set; } = 0;      

        [Display(Name = "Additional Videos")]
        public string AdditionalVideoURLs { get; set; } = string.Empty;

        [Display(Name = "Assembly Required")]
        public string Assembly_Required_YN { get; set; } =  string.Empty;

        [Display(Name = "Installation Type - Bath Accessory")]
        public string Bath_Accessory_Installation_Type { get; set; } = string.Empty;

        [Display(Name = "Bath Shower Diameter")]
        public int Bath_Shower_Diameter { get; set; } = 0;

        [Display(Name = "Bath Shower Maximum Deck Thickness")]
        public double Bath_Shower_Maximum_Deck_Thickness { get; set; } = 0;

        [Display(Name = "Bath Shower Showerhead Face Diameter")]
        public int Bath_Shower_Showerhead_Face_Diameter { get; set; } = 0;

        [Display(Name = "Bath Shower Sprayer Face Diameter")]
        public int Bath_Shower_Sprayer_Face_Diameter { get; set; } = 0;

        [Display(Name = "Batteries Included")]
        public string Batteries_Included_YN { get; set; } = string.Empty;

        [Display(Name = "Battery Weight")]
        public string Battery_Weight { get; set; } = string.Empty;

        [Display(Name = "GROHE")]
        public string Brand { get; set; } = string.Empty;

        [Display(Name = "Bristle Material")]
        public string Bristle_Material { get; set; } = string.Empty;

        [Display(Name = "CAD Drawings 2D")]
        public string CAD_2D_URL { get; set; } = string.Empty;

        [Display(Name = "CAD Drawings 3D")]
        public string CAD_3D_URL { get; set; } = string.Empty;

        [Display(Name = "Color/Finish")]
        public string Color_Code_SAP { get; set; } = string.Empty;

        [Display(Name = "CEC Compliant Product")]
        public string Compliant_Product_Substitute { get; set; } = string.Empty;

        [Display(Name = "Deck Plate Included")]
        public string Deck_Plate_Included_YN { get; set; } = string.Empty;

        [Display(Name = "Dimensional Diagram")]
        public string Dimensional_Drawing_URL { get; set; } = string.Empty;       

        [Display(Name = "EA Each Weight")]
        public double EA_Each_Weight { get; set; } = 0;

        [Display(Name = "Enviornmental Product Declaration")]
        public string EPD_URL { get; set; } = string.Empty;

        [Display(Name = "Sink Faucet Drilling")]
        public int Faucet_Hole_Spacing { get; set; } = 0;

        [Display(Name = "Shower Trim Type")]
        public string Shower_Trim_Type { get; set; } = string.Empty;

        [Display(Name = "Shower Valve Type")]
        public string Shower_Valve_Type { get; set; } = string.Empty;

        [Display(Name = "Installation Type - Wall Bar")]
        public string Shower_Wall_Bar_Installation { get; set; } = string.Empty;

        [Display(Name = "Installation Type - Wall")]
        public string Shower_Wall_Installation_Type { get; set; } = string.Empty;

        [Display(Name = "Showerhead Included")]
        public string Showerhead_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Finish Type - Sink")]
        public string Sink_Finish_Type { get; set; } = string.Empty;

        [Display(Name = "Item Shape - Sink")]
        public string Sink_Shape { get; set; } = string.Empty;

        [Display(Name = "SKU Status")]
        public string SKU_Status { get; set; } = string.Empty;

        [Display(Name = "Soap Lotion Dispenser")]
        public string Soap_Lotion_Dispenser_YN { get; set; } =  string.Empty;

        [Display(Name = "Spray Pattern")]
        public string Spec_Sheet_URL { get; set; } = string.Empty;

        //[Display(Name = "Download Spec Sheet")]
        //public string SprayPattern { get; set; } = string.Empty;

        [Display(Name = "Quantity")]
        public int Stock_Level_SAP { get; set; } = 0;

        [Display(Name = "Trim Kit Included")]
        public string Sink_Rack_Type { get; set; } = string.Empty;

        [Display(Name = "Item Shape - Tub Interior")]
        public string Tub_Interior_Shape { get; set; } = string.Empty;

        [Display(Name = "Voltage")]
        public int Tub_Voltage { get; set; } = 0;       

        [Display(Name = "UPC/EAN")]
        public string UPC_EAN_SAP { get; set; } = string.Empty;

        [Display(Name = "US Launch Date(MM/DD/YYYY)")]
        public DateTime US_Launch_Date_MM_DD_YYYY { get; set; } = DateTime.Now;

        [Display(Name = "Valve Application")]
        public string Valve_Application_YN { get; set; } =  string.Empty;

        [Display(Name = "Where is your valve?")]
        public string Valve_Indoor_Outdoor { get; set; } = string.Empty;

        [Display(Name = "Valve Input Diameter")]
        public int Valve_Input_Diameter { get; set; } = 0;

        [Display(Name = "Valve Output Diameter")]
        public int Valve_Output_Diameter { get; set; } = 0;

        [Display(Name = "Valve Maximum Pressure")]
        public int Valves_Maximum_Pressure { get; set; } = 0;

        [Display(Name = "Valve Maximum Working Temperature")]
        public int Valves_Maximum_Working_Temperature { get; set; } = 0;

        [Display(Name = "Finish Type")]
        public string Vanity_Hardware_Finish_Family { get; set; } = string.Empty;

        [Display(Name = "Features & Benefits Video")]
        public string Video_F_B_URL { get; set; } = string.Empty;

        [Display(Name = "Installation video")]
        public string Video_Install_URL { get; set; } = string.Empty;

        [Display(Name = "Volume Control")]
        public string Volume_Control_YN { get; set; } =  string.Empty;

        [Display(Name = "Warranty")]
        public string Warranty_Type { get; set; } = string.Empty;

        [Display(Name = "Item Volume")]
        public double Volume_SAP { get; set; } = 0;

        [Display(Name = "Water Filter Included")]
        public string Water_Filter_Included_YN { get; set; } = string.Empty;

        [Display(Name = "Maximum Weight Recommendation")]
        public int Weight_Capacity { get; set; } = 0;

        [Display(Name = "LTL")]
        public string Small_Parcel_Postable_SAP_YN { get; set; } =  string.Empty;

        [Display(Name = "Products Using This Part")]
        public string Products_Use_This_Part { get; set; } = string.Empty;

        [Display(Name = "Spare Parts Breakdown")]
        public string SparePartSubcategory { get; set; } = string.Empty;

        [Display(Name = "Spray Type")]
        public string Spray_Pattern_List { get; set; } = string.Empty;

        [Display(Name = "User Instruction Manual")]
        public string User_Instr_PDF_URL { get; set; } = string.Empty;

        [Display(Name = "Use and Care")]
        public string Use_and_Care_URL { get; set; } = string.Empty;

        [Display(Name = "Warranty")]
        public string Warranty_PDF_URL { get; set; } = string.Empty;

        [Display(Name = "About This Product")]
        public string Marketing_Claims_1 { get; set; } = string.Empty;

        [Display(Name = "Product Category")]
        public string SAPLink { get; set; } = string.Empty;      

        [Display(Name = "DC Location")]
        public string DC_Location { get; set; } = string.Empty;

        [Display(Name = "Main Image")]
        public string Main_Image_URL_2000 { get; set; } = string.Empty;

        [Display(Name = "Product Description")]
        public string Marketing_Copy { get; set; } = string.Empty;

        [Display(Name = "Product Name")]
        public string Material_Description_Marketing { get; set; } = string.Empty;

        [Display(Name = "Model Number")]
        public string Mfg_Product_Number_SAP { get; set; } = string.Empty;

        [Display(Name = "Part Number")]
        public string Mfg_Part_Number_SAP { get; set; } = string.Empty;

        [Display(Name = "Mirror Type")]
        public string Mirror_Bath_Product_Type { get; set; } = string.Empty;

        [Display(Name = "Beveled Mirror Frame")]
        public string Mirror_Beveled_Frame_YN { get; set; } =  string.Empty;

        [Display(Name = "Finish Type - Mirror Frame")]
        public string Mirror_Frame_Finish_Family { get; set; } = string.Empty;

        [Display(Name = "Mirror Frame Material")]
        public string Mirror_Frame_Material { get; set; } = string.Empty;

        [Display(Name = "Framed Mirrors/Frameless Mirror")]
        public string Mirror_Framed_Or_Frameless { get; set; } = string.Empty;

        [Display(Name = "Mirror Hardware Included")]
        public string Mirror_Hardware_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Mirror Light")]
        public string Mirror_Light_YN { get; set; } =  string.Empty;

        [Display(Name = "Magnifying Mirror")]
        public string Mirror_Magnifying_YN { get; set; } = string.Empty;

        [Display(Name = "Mirror Mount Location")]
        public string Mirror_Mount_Location { get; set; } = string.Empty;

        [Display(Name = "Item Shape - Mirror")]
        public string Mirror_Shape { get; set; } = string.Empty;

        [Display(Name = "Telescoping Mirror")]
        public string Mirror_Telescoping_YN { get; set; } =  string.Empty;

        [Display(Name = "Mirror Type")]
        public string Mirror_Type { get; set; } = string.Empty;

        [Display(Name = "Safety Data Sheet(SDS or MSDS) URL")]
        public string MSDS_URL { get; set; } = string.Empty;

        [Display(Name = "Made to Order/ Made to Ship")]
        public string MTO_or_MTS { get; set; } = string.Empty;

        [Display(Name = "No. Output Valves Connection")]
        public int Number_Output_Valves_Connection { get; set; } = 0;

        [Display(Name = "Output Connection Type")]
        public string Output_Connection_Type { get; set; } = string.Empty;

        [Display(Name = "Model Number")]
        public string ParentNumber { get; set; } = string.Empty;

        [Display(Name = "Number of Boxes")]
        public string Number_Of_Boxes { get; set; } = string.Empty;

        [Display(Name = "Collection")]
        public string Product_Family_SAP { get; set; } = string.Empty;

        [Display(Name = "Product Style")]
        public string Product_Style { get; set; } = string.Empty;

        [Display(Name = "Related Products")]
        public string Related_Products { get; set; } = string.Empty;

        [Display(Name = "Replacement Parts Diagram")]
        public string Replacement_Parts_Doc_URL { get; set; } = string.Empty;

        [Display(Name = "Restricted Ship States")]
        public string Restricted_States_Regulated { get; set; } = string.Empty;

        [Display(Name = "Replacement Parts")]
        public string Replacement_Material { get; set; } = string.Empty;

        [Display(Name = "Residential or Commercial")]
        public string Residential_Or_Commercial { get; set; } = string.Empty;

        [Display(Name = "DC Location - Shipping Plants")]
        public string Shipping_Plants_SAP { get; set; } = string.Empty;

        [Display(Name = "Shower Arm Style")]
        public string Shower_Arm_Style { get; set; } = string.Empty;

        [Display(Name = "Shower Diverter Type")]
        public string Shower_Diverter_Type { get; set; } = string.Empty;

        [Display(Name = "Shower No. of Showerheads")]
        public int Shower_No_Of_Showerheads { get; set; } = 0;

        [Display(Name = "Shower No. of Spray Settings")]
        public int Shower_No_Of_Spray_Settings { get; set; } = 0;

        [Display(Name = "Shower No. of Jets")]
        public int Shower_No_Of_Jets { get; set; } = 0;

        [Display(Name = "Shower Rough in Valve")]
        public int Shower_Rough_In_Valve { get; set; } = 0;

        [Display(Name = "Fitting Connection Size")]
        public double Fitting_Connection_Size_Input { get; set; } = 0;
       

        [Display(Name = "Fitting Handle Height")]
        public int Fitting_Handle_Height { get; set; } = 0;

        [Display(Name = "Fitting Handle Type")]
        public string Fitting_Handle_Type { get; set; } = string.Empty;

        [Display(Name = "Fitting Hose Length")]
        public int Fitting_Hose_Length { get; set; } = 0;

        [Display(Name = "Fitting Material")]
        public string Fitting_Material { get; set; } = string.Empty;

        [Display(Name = "Fitting Max Deck Thickness")]
        public int Fitting_Max_Deck_Thickness { get; set; } = 0;

        [Display(Name = "Fitting Max Deck Thickness with Escutcheon")]
        public int Fitting_Max_Deck_Thickness_w_Escutcheon { get; set; } = 0;

        [Display(Name = "Fitting Mount Type")]
        public string Fitting_Mount_Type { get; set; } = string.Empty;

        [Display(Name = "No. of Handles")]
        public int Fitting_No_Of_Handles { get; set; } = 0;

        [Display(Name = "Fitting No. of Holes Required")]
        public int Fitting_No_Of_Holes_Required { get; set; } = 0;

        [Display(Name = "Fitting Speed Connect")]
        public string Fitting_Speed_Connect_YN { get; set; } =  string.Empty;

        [Display(Name = "Dimensions")]
        public int Fitting_Spout_Height { get; set; } = 0;

        [Display(Name = "Fitting Spout Reach")]
        public int Fitting_Spout_Reach { get; set; } = 0;

        [Display(Name = "Spout Height")]
        public string Fitting_Spout_Type { get; set; } = string.Empty;

        [Display(Name = "Fitting swivel Degrees")]
        public int Fitting_Swivel_Degrees { get; set; } = 0;

        [Display(Name = "Hinge Material")]
        public string Hinge_Material { get; set; } = string.Empty;

        [Display(Name = "Fitting Valve Needed for Install")]
        public string Fitting_Valve_Needed_For_Install_YN { get; set; } =  string.Empty;

        [Display(Name = "Fitting Material")]
        public string Fixture_Material { get; set; } = string.Empty;

        [Display(Name = "Finish Type - Frame")]
        public string Frame_Finish { get; set; } = string.Empty;

        [Display(Name = "Flow Rate")]
        public string FlowRateGPC { get; set; } = string.Empty;

        [Display(Name = "Moments of Truth")]
        public string Grohe_MOT { get; set; } = string.Empty;

        [Display(Name = "Item Shape - Hand Head Shower")]
        public string Hand_Head_Shower_Shape { get; set; } = string.Empty;

        [Display(Name = "Hand Shower Included")]
        public string Hand_Shower_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Finish Type - Handle")]
        public string Handle_Finish { get; set; } = string.Empty;

        [Display(Name = "Handle Length")]
        public int Handle_Length { get; set; } = 0;

        [Display(Name = "Handle To Handle Measurement")]
        public string Handle_To_Handle_Measurement { get; set; } = string.Empty;

        [Display(Name = "Fitting Valve Material")]
        public string Fitting_Valve_Material { get; set; } = string.Empty;

        [Display(Name = "Hose Included")]
        public string Hose_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Included Components")]
        public string Included_Components { get; set; } = string.Empty;

        [Display(Name = "Infographic")]
        public string Infographic_URL { get; set; } = string.Empty;

        [Display(Name = "Input Connection Type")]
        public string Input_Connection_Type { get; set; } = string.Empty;

        [Display(Name = "Installation Hardware Included")]
        public string Installation_Hardware_Included { get; set; } = string.Empty;

        [Display(Name = "Installation Sheets")]
        public string Installation_Instruction_URL { get; set; } = string.Empty;

        [Display(Name = "Kit")]
        public string Kit_SMO_POD { get; set; } = string.Empty;

        [Display(Name = "Kitchen or Bathroom Product")]
        public string Kitchen_Bath { get; set; } = string.Empty;

        [Display(Name = "Installation Type - Kitchen Sink")]
        public string Kitchen_Sink_Mount_Location { get; set; } = string.Empty;

        [Display(Name = "Lead Law Compliant")]
        public string Lead_Law_Compliant_YN { get; set; } = string.Empty;

        [Display(Name = "Lifestyle Images")]
        public string Lifestyle_Image_Address { get; set; } = string.Empty;

        [Display(Name = "List Price")]
        public double List_Price { get; set; } = 0;       

        [Display(Name = "Tub Wattage")]
        public string Tub_Wattage { get; set; } = string.Empty;

        [Display(Name = "Maximum Occupants")]
        public int Max_Occupants { get; set; } = 0;

        [Display(Name = "Tub Blower Placement")]
        public string Tub_Blower_Placement { get; set; } = string.Empty;

        [Display(Name = "Tub Pump Placement")]
        public string Tub_Pump_Placement { get; set; } = string.Empty;

        [Display(Name = "Tub Pump Speeds")]
        public int Tub_Pump_Speeds { get; set; } = 0;

        [Display(Name = "Tub Sound Dampening")]
        public string Tub_Sound_Dampening { get; set; } =  string.Empty;

        [Display(Name = "Tank Included")]
        public string Tank_Included_YN { get; set; } = string.Empty;

        [Display(Name = "Sink Predrilled Holes")]
        public string Sink_Predrilled_Holes_YN { get; set; } =  string.Empty;

        [Display(Name = "Number of Trapways")]
        public string Number_Of_Toilet_Trapways { get; set; } = string.Empty;

        [Display(Name = "Mold")]
        public string Mold { get; set; } = string.Empty;

        [Display(Name = "Number of Toilet Flush Valves")]
        public int Number_Of_Toilet_Flush_Valves { get; set; } = 0;

        [Display(Name = "No. of Dryer Settings")]
        public int Bidet_No_Of_Dryer_Settings { get; set; } = 0;

        [Display(Name = "No. of Spray Nozzles")]
        public int Bidet_No_Of_Spray_Nozzles { get; set; } = 0;

        [Display(Name = "No. of Water Control Settings")]
        public int Bidet_No_Of_Water_Control_Settings { get; set; } = 0;

        [Display(Name = "Bidet Spray Type")]
        public string Bath_Fitting_Bidet_Spray_Type { get; set; } = string.Empty;

        [Display(Name = "Power Cord Length")]
        public int Power_Cord_Length { get; set; } = 0;

        [Display(Name = "Toilet Seat Front Type")]
        public string Toilet_Seat_Front_Type { get; set; } = string.Empty;        

        [Display(Name = "Flushing Mechanism")]
        public string Flushing_Mechanism { get; set; } = string.Empty;

        [Display(Name = "Flushing Type")]
        public string Flushing_Type { get; set; } = string.Empty;

        [Display(Name = "No of Batteries Included")]
        public string No_Of_Batteries_Included { get; set; } = string.Empty;        

        [Display(Name = "No. of Finished Sides")]
        public int Shower_Base_No_Finished_Sides { get; set; } = 0;

        [Display(Name = "No. of Curbs")]
        public int Shower_Base_Number_Of_Curbs { get; set; } = 0;       

        [Display(Name = "Door Glass Thickness")]
        public string Door_Glass_Thickness { get; set; } = string.Empty;

        [Display(Name = "Door Hinged")]
        public string Door_Hinged_YN { get; set; } =  string.Empty;

        [Display(Name = "Door Swing")]
        public string Door_Swing { get; set; } = string.Empty;

        [Display(Name = "Door Usage")]
        public string Door_Usage { get; set; } = string.Empty;

        [Display(Name = "Drain Location")]
        public string Drain_Location { get; set; } = string.Empty;

        [Display(Name = "Towel Bar Included")]
        public string Towel_Bar_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Door Width")]
        public double Tub_Shower_Door_Width { get; set; } = 0;

        [Display(Name = "Caulkless Shower Wall")]
        public string Shower_Wall_Caulkless_YN { get; set; } =  string.Empty;

        [Display(Name = "Shower Wall Construction")]
        public string Shower_Wall_Construction { get; set; } = string.Empty;

        [Display(Name = "Shower Wall No. of Shelves")]
        public int Shower_Wall_Number_Of_Shelves { get; set; } = 0;

        [Display(Name = "Shower Wall Surface")]
        public string Shower_Wall_Surface { get; set; } = string.Empty;

        [Display(Name = "Bowl Right Side Below Counter Depth")]
        public double Bowl_Right_Side_Below_Counter_Depth { get; set; } = 0;

        [Display(Name = "Sink Cut-Out Below Counter Depth")]
        public double Sink_Cut_Out_Below_Counter_Depth { get; set; } = 0;

        [Display(Name = "Sink Cut-Out Front to Back Width")]
        public double Sink_Cut_Out_Front_To_Back_Width { get; set; } = 0;

        [Display(Name = "Sink Cut-Out Left to Right Length")]
        public double Sink_Cut_Out_Left_To_Right_Length { get; set; } = 0;

        [Display(Name = "Depth to Overflow")]
        public double Sink_Depth_To_Overflow { get; set; } = 0;

        [Display(Name = "Minimum Cabinet Size")]
        public int Sink_Minimum_Cabinet_Size { get; set; } = 0;

        [Display(Name = "Sink Overflow Location")]
        public string Sink_Overflow_Location { get; set; } = string.Empty;

        [Display(Name = "Handle Style")]
        public string Handle_Style { get; set; } = string.Empty;

        [Display(Name = "Jet Type")]
        public string Jet_Type { get; set; } = string.Empty;

        [Display(Name = "Soaking Depth")]
        public double Soaking_Depth { get; set; } = 0;

        [Display(Name = "Tub Blower")]
        public string Tub_Blower { get; set; } = string.Empty;

        [Display(Name = "Tub Lighting")]
        public string Tub_Lighting { get; set; } = string.Empty;

        [Display(Name = "Tub Pump Amperage")]
        public int Tub_Pump_Amperage { get; set; } = 0;

        [Display(Name = "Tub Water Capacity")]
        public int Tub_Water_Capacity { get; set; } = 0;

        [Display(Name = "Features - Kitchen Sink Accessory")]
        public string Kitchen_Sink_Accessory_Grid_Features { get; set; } = string.Empty;

        [Display(Name = "Accessory Type")]
        public string Sink_Accessory_Type { get; set; } = string.Empty;

        [Display(Name = "Sink Below Counter Depth")]
        public double Sink_Bowl_Below_Counter_Depth { get; set; } = 0;

        [Display(Name = "Sink Front to back Width")]
        public double Sink_Front_To_Back_Width { get; set; } = 0;

        [Display(Name = "Sink Left to Right Length")]
        public double Sink_Left_To_Right_Length { get; set; } = 0;

        [Display(Name = "Sink Top to Bottom Depth")]
        public double Sink_Top_To_Bottom_Depth { get; set; } = 0;

        [Display(Name = "Style - Tub Exterior")]
        public string Tub_Exterior_Shape { get; set; } = string.Empty;

        [Display(Name = "Sump Length")]
        public double Sump_Length { get; set; } = 0;

        [Display(Name = "Sump Width")]
        public double Sump_Width { get; set; } = 0;

        [Display(Name = "Features")]
        public string Tub_Features { get; set; } = string.Empty;

        [Display(Name = "Tub Type")]
        public string Tub_Product_Type { get; set; } = string.Empty;

        [Display(Name = "Bowl Dimensions")]
        public int Bowl_Front_To_Back_Length { get; set; } = 0;

        [Display(Name = "Flow Rate")]
        public string Flow_Rate { get; set; } = string.Empty;

        [Display(Name = "Flush Technology")]
        public string Flush_Technology { get; set; } = string.Empty;

        [Display(Name = "Bowl Included")]
        public string Bowl_Included_YN { get; set; } = string.Empty;

        [Display(Name = "Bath Accessory Application")]
        public string Bath_Accessory_Application { get; set; } = string.Empty;

        [Display(Name = "Batteries Required")]
        public string Batteries_Required { get; set; } = string.Empty;

        [Display(Name = "Battery Lifetime Cycles")]
        public string Battery_Lifetime_Cycles { get; set; } = string.Empty;

        [Display(Name = "Sink Bowl Split")]
        public string Sink_Bowl_Split { get; set; } = string.Empty;

        [Display(Name = "Integral Dish Rack")]
        public string Sink_Integral_Dish_Rack_YN { get; set; } =  string.Empty;

        [Display(Name = "Sink Type")]
        public string Kitchen_Sink_Product_Type { get; set; } = string.Empty;        

        [Display(Name = "Included In Box")]
        public string Included_In_Box { get; set; } = string.Empty;

        [Display(Name = "Freestanding Tub Style")]
        public string Freestanding_Tub_Style { get; set; } = string.Empty;

        [Display(Name = "Faucet Included")]
        public string Faucet_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Removable")]
        public string Removable_YN { get; set; } = string.Empty;

        [Display(Name = "Map Performance Rating")]
        public int MAP_Performance_Rating { get; set; } = 0;

        [Display(Name = "Activation Lever Location")]
        public string Toilet_Activation_Lever_Location { get; set; } = string.Empty;

        [Display(Name = "Sink Bath Type")]
        public string Sink_Bath_Type { get; set; } = string.Empty;

        [Display(Name = "Bowl Height Without Seat")]
        public double Bowl_Height_Without_Seat { get; set; } = 0;

        [Display(Name = "No. of Sink Basins")]
        public int Sink_No_Of_Basins { get; set; } = 0;

        [Display(Name = "No. of Sink Pieces")]
        public int Sink_No_Of_Pieces { get; set; } = 0;

        [Display(Name = "Trim Kit Included")]
        public string Trim_Kit_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Type")]
        public string Sink_Product_Type { get; set; } = string.Empty;

        [Display(Name = "Kitchen Sink Accessory Rack type")]
        public string Kitchen_Sink_Accessory_Rack_Type { get; set; } = string.Empty;

        [Display(Name = "Tub Shower Door Fits Opening Height")]
        public double Tub_Shower_Door_Fits_Opening_Height { get; set; } = 0;

        [Display(Name = "Tub Shower Door Glass Thickness")]
        public int Tub_Shower_Door_Glass_Thickness { get; set; } = 0;

        [Display(Name = "Tub Shower Door Height")]
        public double Tub_Shower_Door_Height { get; set; } = 0;

        [Display(Name = "Tub Shower Door Opening Width Max")]
        public int Tub_Shower_Door_Opening_Width_Max { get; set; } = 0;

        [Display(Name = "Tub Shower Door Opening Width Min")]
        public double Tub_Shower_Door_Opening_Width_Min { get; set; } = 0;

        [Display(Name = "Door Glass Style")]
        public string Door_Glass_Style { get; set; } = string.Empty;

        [Display(Name = "Door Type")]
        public string Door_Type { get; set; } = string.Empty;

        [Display(Name = "Frame Type")]
        public string Frame_Type { get; set; } = string.Empty;

        [Display(Name = "Flush Valve Size")]
        public double Flush_Valve_Size { get; set; } = 0;

        [Display(Name = "No. of Flush Valves")]
        public int Number_Of_Flush_Valves { get; set; } = 0;

        [Display(Name = "Operating Pressure Flushing")]
        public int Operating_Pressure_Flushing { get; set; } = 0;

        [Display(Name = "Operating Pressure Static")]
        public int Operating_Pressure_Static { get; set; } = 0;

        [Display(Name = "Rough In Size")]
        public double Rough_In_Size { get; set; } = 0;

        [Display(Name = "Rough In Valve Included")]
        public string Rough_In_Valve_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Toilet Bowl Height with Seat")]
        public int Toilet_Bowl_Height_With_Seat { get; set; } = 0;

        [Display(Name = "Toilet Trapway Diameter")]
        public int Toilet_Trapway_Diameter { get; set; } = 0;

        [Display(Name = "No. of Heat Settings")]
        public int Bidet_No_Of_Heat_Settings { get; set; } = 0;

        [Display(Name = "Bidet Remote Included")]
        public string Bidet_Remote_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Slow Close Seat")]
        public string Bidet_Slow_Close_Lid_YN { get; set; } =  string.Empty;

        [Display(Name = "Chemical Composition Of Battery")]
        public string Chemical_Composition_Of_Battery { get; set; } = string.Empty;

        [Display(Name = "Toilet Seat Bolt Spread")]
        public int Toilet_Seat_Bolt_Spread { get; set; } = 0;

        [Display(Name = "Escutcheon Internal Diameter")]
        public int Escutcheon_Internal_Diameter { get; set; } = 0;

        [Display(Name = "No. Input Valves connection")]
        public int Number_Input_Valves_Connection { get; set; } = 0;

        [Display(Name = "Bath Accessory Weight Capacity")]
        public int Bath_Accessory_Weight_Capacity { get; set; } = 0;

        [Display(Name = "Bath Accessory Hanger Type")]
        public string Bath_Accessory_Hanger_Type { get; set; } = string.Empty;

        [Display(Name = "Accessory Hardware Included")]
        public string Bath_Accessory_Hardware_Included_YN { get; set; } =  string.Empty;

        [Display(Name = "Accessory Holder Type")]
        public string Bath_Accessory_Holder_Type { get; set; } = string.Empty;

        [Display(Name = "Accessory Hook Type")]
        public string Bath_Accessory_Hook_Type { get; set; } = string.Empty;

        [Display(Name = "Accessory Mount Type")]
        public string Bath_Accessory_Mount_Type { get; set; } = string.Empty;

        [Display(Name = "Bath Accessory Mounting Hardware")]
        public string Bath_Accessory_Mounting_Hardware_YN { get; set; } =  string.Empty;

        [Display(Name = "No. of Bars")]
        public int Bath_Accessory_No_Of_Bars { get; set; } = 0;

        [Display(Name = "No. of Chambers")]
        public int Bath_Accessory_No_Of_Chambers { get; set; } = 0;

        [Display(Name = "No. of Hangers")]
        public int Bath_Accessory_No_Of_Hangers { get; set; } = 0;

        [Display(Name = "No. of Hooks")]
        public int Bath_Accessory_No_Of_Hooks { get; set; } = 0;

        [Display(Name = "No. of Pieces")]
        public int Bath_Accessory_No_Of_Pieces { get; set; } = 0;

        [Display(Name = "Product Type")]
        public string Bath_Accessory_Product_Type { get; set; } = string.Empty;

        [Display(Name = "Textured Grip")]
        public string Bath_Accessory_Textured_Grip_YN { get; set; } =  string.Empty;

        [Display(Name = "Bathroom Accessory Type")]
        public string Bath_Accessory_Type { get; set; } = string.Empty;

        [Display(Name = "Bristle Stiffness")]
        public int Bristle_Stiffness { get; set; } = 0;

        [Display(Name = "Bristle Length")]
        public int Bristle_Length { get; set; } = 0;

        [Display(Name = "Dimensions")]
        public string Shower_Arm_Reach { get; set; } = string.Empty;

        [Display(Name = "Shower Corrosion Resistant")]
        public string Shower_Corrosion_Resistant_YN { get; set; } =  string.Empty;

        [Display(Name = "Dimensions")]
        public int Shower_Wall_Bar_Length { get; set; } = 0;

        [Display(Name = "Rough in valves Features")]
        public string Rough_In_Valve_Features { get; set; } = string.Empty;

        [Display(Name = "Product Exclusive")]
        public string Customer_Exclusive_Material_YN { get; set; } =  string.Empty;
    }
}

