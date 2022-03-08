<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody\data\modifyUser;
use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody\data\originator;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 数据创建时间
     *
     * @var string
     */
    public $createdTimeGMT;

    /**
     * @description 创建人
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 实体主键id
     *
     * @var int
     */
    public $dataId;

    /**
     * @description 表单数据
     *
     * @var mixed[]
     */
    public $formData;

    /**
     * @description 表单实例ID
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 表单id
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 表单实例原始格式值
     *
     * @var string
     */
    public $instanceValue;

    /**
     * @description 模型id
     *
     * @var string
     */
    public $modelUuid;

    /**
     * @description 最近修改时间
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @description 修改人
     *
     * @var string
     */
    public $modifierUserId;

    /**
     * @description 修改者
     *
     * @var modifyUser
     */
    public $modifyUser;

    /**
     * @description 发起人
     *
     * @var originator
     */
    public $originator;

    /**
     * @description 批次号
     *
     * @var string
     */
    public $sequence;

    /**
     * @description 流水号
     *
     * @var string
     */
    public $serialNo;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 数据版本
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'createdTimeGMT'  => 'createdTimeGMT',
        'creatorUserId'   => 'creatorUserId',
        'dataId'          => 'dataId',
        'formData'        => 'formData',
        'formInstanceId'  => 'formInstanceId',
        'formUuid'        => 'formUuid',
        'instanceValue'   => 'instanceValue',
        'modelUuid'       => 'modelUuid',
        'modifiedTimeGMT' => 'modifiedTimeGMT',
        'modifierUserId'  => 'modifierUserId',
        'modifyUser'      => 'modifyUser',
        'originator'      => 'originator',
        'sequence'        => 'sequence',
        'serialNo'        => 'serialNo',
        'title'           => 'title',
        'version'         => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdTimeGMT) {
            $res['createdTimeGMT'] = $this->createdTimeGMT;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->dataId) {
            $res['dataId'] = $this->dataId;
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
        if (null !== $this->instanceValue) {
            $res['instanceValue'] = $this->instanceValue;
        }
        if (null !== $this->modelUuid) {
            $res['modelUuid'] = $this->modelUuid;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->modifierUserId) {
            $res['modifierUserId'] = $this->modifierUserId;
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
        if (null !== $this->serialNo) {
            $res['serialNo'] = $this->serialNo;
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
        if (isset($map['createdTimeGMT'])) {
            $model->createdTimeGMT = $map['createdTimeGMT'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['dataId'])) {
            $model->dataId = $map['dataId'];
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
        if (isset($map['instanceValue'])) {
            $model->instanceValue = $map['instanceValue'];
        }
        if (isset($map['modelUuid'])) {
            $model->modelUuid = $map['modelUuid'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['modifierUserId'])) {
            $model->modifierUserId = $map['modifierUserId'];
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
        if (isset($map['serialNo'])) {
            $model->serialNo = $map['serialNo'];
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
