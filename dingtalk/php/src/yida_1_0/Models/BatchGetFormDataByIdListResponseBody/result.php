<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchGetFormDataByIdListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchGetFormDataByIdListResponseBody\result\modifyUser;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\BatchGetFormDataByIdListResponseBody\result\originator;
use AlibabaCloud\Tea\Model;

class result extends Model
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
     * @example {"addressField_l0c1cwiy_id":"\"海南省/469027/国营红岗农场/111\"","associationFormField_l0c1hdz4_id":"\"[{\\\"formType\\\":\\\"receipt\\\",\\\"formUuid\\\":\\\"FORM-QQ866JB1QW8YM5XZZZ64VQB61OGM1MLWE1C0LG\\\",\\\"instanceId\\\":\\\"FINST-CC666Y6198RY0LAN39XGND212MSX3TFT95S0LN31\\\",\\\"subTitle\\\":\\\"{\\\\\\\"type\\\\\\\":\\\\\\\"div\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":{\\\\\\\"type\\\\\\\":\\\\\\\"a\\\\\\\",\\\\\\\"props\\\\\\\":{\\\\\\\"children\\\\\\\":\\\\\\\"查看签名\\\\\\\",\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item-link\\\\\\\",\\\\\\\"style\\\\\\\":{\\\\\\\"cursor\\\\\\\":\\\\\\\"pointer\\\\\\\",\\\\\\\"color\\\\\\\":\\\\\\\"#0068ff\\\\\\\"}}},\\\\\\\"className\\\\\\\":\\\\\\\"inst-cell-item\\\\\\\"}}\\\",\\\"appType\\\":\\\"APP_K6IGJJ6PFAARLPDSWKXQ\\\",\\\"title\\\":\\\"1\\\"}]\"","countrySelectField_l0c1cwiu_id":["PG"]}
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
     * @example 符合宜搭表单实例格式的json数据
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
     * @return result
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
