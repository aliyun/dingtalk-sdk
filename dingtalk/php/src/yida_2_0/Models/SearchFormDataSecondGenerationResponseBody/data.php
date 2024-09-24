<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataSecondGenerationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataSecondGenerationResponseBody\data\modifyUser;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataSecondGenerationResponseBody\data\originator;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 2021-05-01
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @example ding12345
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @example {"addressField_l0c1cwiy_id":"\"海南省/469027/国营红岗农场/111\"","associationFormField_l0c1hdz4_id":"\"[{\\\"formType\\\":\\\"receipt\\\",\\\"formUuid\\\":\\\"FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\\\",\\\"instanceId\\\":\\\"FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\\\",\\\"subTitle\\\":\\\"{\\\\\\\"type\\\\\\\":\\\\\\\"div\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":{\\\\\\\"type\\\\\\\":\\\\\\\"a\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":\\\\\\\"查看签名\\\\\\\",\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item-link\\\\\\\",\\\\\\\"style\\\\\\\":{\\\\\\\"cursor\\\\\\\":\\\\\\\"pointer\\\\\\\",\\\\\\\"color\\\\\\\":\\\\\\\"#0068ff\\\\\\\"}}},\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item\\\\\\\"}}\\\",\\\"appType\\\":\\\"APP_K6IGJJ6PFAARLPDSWKXQ\\\",\\\"title\\\":\\\"1\\\"}]\"","countrySelectField_l0c1cwiu_id":["PG"],"imageField_l0c1cwit":"[{\"previewUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80\",\"size\":2610734,\"name\":\"Bts2Z0e6oxA.jpg\",\"downloadUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\",\"url\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\"}]","rateField_l0c1cwis_value":"3","editorField_l0c1cwiz":"<div><strong>你好，这是测试</strong></div>\r\n<div><span style=\"font-family: kaiti;background-color: #ff0000;color: #ffff00;\"><em><strong>测试</strong></em></span></div>\r\n<div>&nbsp;</div>","rateField_l0c1cwis":3,"countrySelectField_l0c1cwiu":[],"attachmentField_l0ghkwv3":"[{\"downloadUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\",\"name\":\"Bts2Z0e6oxA.jpg\",\"previewUrl\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80\",\"size\":2610734,\"url\":\"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download\"}]","addressField_l0c1cwiy":"{\"address\":\"111\",\"regionIds\":[460000,469027,469023401],\"regionText\":[{\"en_US\":\"hai+nan+sheng\",\"zh_CN\":\"海南省\"},{\"en_US\":\"cheng+mai+xian\",\"zh_CN\":\"澄迈县\"},{\"en_US\":\"guo+ying+hong+gang+nong+chang\",\"zh_CN\":\"国营红岗农场\"}]}"}
     *
     * @var mixed[]
     */
    public $formData;

    /**
     * @example FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example 12345
     *
     * @var int
     */
    public $id;

    /**
     * @example [{"componentName":"CountrySelectField","dateType":null,"fieldData":{"value":[{"text":{"en_US":"Papua New Guinea","zh_CN":"巴布亚新几内亚","type":"i18n"},"value":"PG"}]},"fieldDataUpdated":false,"fieldId":"countrySelectField_l0c1cwiu","format":null,"formatControls":null,"listNum":null,"options":[{"label":{"$ref":"$[0].fieldData.value[0].text"},"value":"PG"}],"rowId":null},{"componentName":"AssociationFormField","dateType":null,"fieldData":{"value":[{"formType":"receipt","formUuid":"FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG","instanceId":"FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31","subTitle":"{\"type\":\"div\",\"props\":{\"children\":{\"type\":\"a\",\"props\":{\"children\":\"查看签名\",\"className\":\"inst-cell-item-link\",\"style\":{\"cursor\":\"pointer\",\"color\":\"#0068ff\"}}},\"className\":\"inst-cell-item\"}}","appType":"APP_K6IGJJ6PFAARLPDSWKXQ","title":"1"}]},"fieldDataUpdated":false,"fieldId":"associationFormField_l0c1hdz4","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"ImageField","dateType":null,"fieldData":{"value":[{"previewUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80","size":2610734,"name":"Bts2Z0e6oxA.jpg","downloadUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download","url":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download"}]},"fieldDataUpdated":false,"fieldId":"imageField_l0c1cwit","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"AddressField","dateType":null,"fieldData":{"value":{"address":"111","regionIds":[460000,469027,469023401],"regionText":[{"en_US":"hai+nan+sheng","zh_CN":"海南省"},{"en_US":"cheng+mai+xian","zh_CN":"澄迈县"},{"en_US":"guo+ying+hong+gang+nong+chang","zh_CN":"国营红岗农场"}]}},"fieldDataUpdated":false,"fieldId":"addressField_l0c1cwiy","format":null,"formatControls":null,"listNum":null,"options":[{"label":{"pureEn_US":"hai+nan+sheng","en_US":"hai+nan+sheng","zh_CN":"海南省","type":"i18n","key":null},"value":460000},{"label":{"pureEn_US":"cheng+mai+xian","en_US":"cheng+mai+xian","zh_CN":"澄迈县","type":"i18n","key":null},"value":469027},{"label":{"pureEn_US":"guo+ying+hong+gang+nong+chang","en_US":"guo+ying+hong+gang+nong+chang","zh_CN":"国营红岗农场","type":"i18n","key":null},"value":469023401}],"rowId":null},{"componentName":"EditorField","dateType":null,"fieldData":{"value":"<div><strong>你好，这是测试</strong></div>\r\n<div><span style=\"font-family: kaiti;background-color: #ff0000;color: #ffff00;\"><em><strong>测试</strong></em></span></div>\r\n<div>&nbsp;</div>"},"fieldDataUpdated":false,"fieldId":"editorField_l0c1cwiz","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"RateField","dateType":null,"fieldData":{"value":"3"},"fieldDataUpdated":false,"fieldId":"rateField_l0c1cwis","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null},{"componentName":"AttachmentField","dateType":null,"fieldData":{"value":[{"previewUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=open&process=image/resize,m_fill,w_200,h_200,limit_0/quality,q_80","size":2610734,"name":"Bts2Z0e6oxA.jpg","downloadUrl":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download","url":"/ossFileHandle?appType=APP_K6IGJJ6PFAARLPDSWKXQ&fileName=APP_K6IGJJ6PFAARLPDSWKXQ_MTczMjU1NjYyMzg3MzI0NF8wUDk2NlQ2MVIzR1lHV1RaMjMxQ1A5U1Y1NU1NM1lMWVY1QzBMMQ$$.jpg&instId=&type=download"}]},"fieldDataUpdated":false,"fieldId":"attachmentField_l0ghkwv3","format":null,"formatControls":null,"listNum":null,"options":[],"rowId":null}]
     *
     * @var string
     */
    public $instanceValue;

    /**
     * @example 2021-05-01
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @example manager123
     *
     * @var string
     */
    public $modifier;

    /**
     * @var modifyUser
     */
    public $modifyUser;

    /**
     * @var originator
     */
    public $originator;

    /**
     * @example IMPORT-388664B1BAUVB3AYZE1RIUE88TDM1QI9WIOWK2
     *
     * @var string
     */
    public $sequence;

    /**
     * @example YIDA909202202250027
     *
     * @var string
     */
    public $serialNumber;

    /**
     * @example 李四发起的请购单
     *
     * @var string
     */
    public $title;

    /**
     * @example 1.0
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'createTimeGMT'   => 'createTimeGMT',
        'creatorUserId'   => 'creatorUserId',
        'formData'        => 'formData',
        'formInstanceId'  => 'formInstanceId',
        'formUuid'        => 'formUuid',
        'id'              => 'id',
        'instanceValue'   => 'instanceValue',
        'modifiedTimeGMT' => 'modifiedTimeGMT',
        'modifier'        => 'modifier',
        'modifyUser'      => 'modifyUser',
        'originator'      => 'originator',
        'sequence'        => 'sequence',
        'serialNumber'    => 'serialNumber',
        'title'           => 'title',
        'version'         => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->formData) {
            $res['formData'] = $this->formData;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->instanceValue) {
            $res['instanceValue'] = $this->instanceValue;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = $this->modifier;
        }
        if (null !== $this->modifyUser) {
            $res['modifyUser'] = null !== $this->modifyUser ? $this->modifyUser->toMap() : null;
        }
        if (null !== $this->originator) {
            $res['originator'] = null !== $this->originator ? $this->originator->toMap() : null;
        }
        if (null !== $this->sequence) {
            $res['sequence'] = $this->sequence;
        }
        if (null !== $this->serialNumber) {
            $res['serialNumber'] = $this->serialNumber;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['formData'])) {
            $model->formData = $map['formData'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['instanceValue'])) {
            $model->instanceValue = $map['instanceValue'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = $map['modifier'];
        }
        if (isset($map['modifyUser'])) {
            $model->modifyUser = modifyUser::fromMap($map['modifyUser']);
        }
        if (isset($map['originator'])) {
            $model->originator = originator::fromMap($map['originator']);
        }
        if (isset($map['sequence'])) {
            $model->sequence = $map['sequence'];
        }
        if (isset($map['serialNumber'])) {
            $model->serialNumber = $map['serialNumber'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
