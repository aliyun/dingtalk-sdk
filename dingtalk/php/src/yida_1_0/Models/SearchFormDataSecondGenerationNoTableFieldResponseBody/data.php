<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationNoTableFieldResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationNoTableFieldResponseBody\data\modifyUser;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationNoTableFieldResponseBody\data\originator;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @description 创建者的userId
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 表单实例数据。结构说明参考 https://www.yuque.com/yida/support/agb8im#jksEx
     *
     * @var mixed[]
     */
    public $formData;

    /**
     * @description 表单实例id
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 数据库表记录主键id
     *
     * @var int
     */
    public $id;

    /**
     * @description 表单实例数据以组件值格式展示
     *
     * @var string
     */
    public $instanceValue;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @description 修改者的钉钉userId
     *
     * @var string
     */
    public $modifier;

    /**
     * @description 修改者
     *
     * @var modifyUser
     */
    public $modifyUser;

    /**
     * @description 表单实例提交人
     *
     * @var originator
     */
    public $originator;

    /**
     * @description 此表单实例所对应的批量导入批次号(如果该表单实例是通过批量导入创建的)
     *
     * @var string
     */
    public $sequence;

    /**
     * @description 流水号
     *
     * @var string
     */
    public $serialNumber;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 该表单实例对应的表单schema版本
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
