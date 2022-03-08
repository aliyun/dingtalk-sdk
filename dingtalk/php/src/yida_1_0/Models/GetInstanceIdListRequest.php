<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInstanceIdListRequest extends Model
{
    /**
     * @description 应用ID
     *
     * @var string
     */
    public $appType;

    /**
     * @description 流程审批结果
     *
     * @var string
     */
    public $approvedResult;

    /**
     * @description createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表
     *
     * @var string
     */
    public $createFromTimeGMT;

    /**
     * @description createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表。
     *
     * @var string
     */
    public $createToTimeGMT;

    /**
     * @description 表单ID
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 实例状态
     *
     * @var string
     */
    public $instanceStatus;

    /**
     * @description 语言
     *
     * @var string
     */
    public $language;

    /**
     * @description modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表
     *
     * @var string
     */
    public $modifiedFromTimeGMT;

    /**
     * @description modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。
     *
     * @var string
     */
    public $modifiedToTimeGMT;

    /**
     * @description 根据流程发起人工号查询
     *
     * @var string
     */
    public $originatorId;

    /**
     * @description 根据表单内组件值查询
     *
     * @var string
     */
    public $searchFieldJson;

    /**
     * @description 应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 任务ID
     *
     * @var string
     */
    public $taskId;

    /**
     * @description 钉钉的userId
     *
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'appType'             => 'appType',
        'approvedResult'      => 'approvedResult',
        'createFromTimeGMT'   => 'createFromTimeGMT',
        'createToTimeGMT'     => 'createToTimeGMT',
        'formUuid'            => 'formUuid',
        'instanceStatus'      => 'instanceStatus',
        'language'            => 'language',
        'modifiedFromTimeGMT' => 'modifiedFromTimeGMT',
        'modifiedToTimeGMT'   => 'modifiedToTimeGMT',
        'originatorId'        => 'originatorId',
        'searchFieldJson'     => 'searchFieldJson',
        'systemToken'         => 'systemToken',
        'taskId'              => 'taskId',
        'userId'              => 'userId',
        'pageNumber'          => 'pageNumber',
        'pageSize'            => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->approvedResult) {
            $res['approvedResult'] = $this->approvedResult;
        }
        if (null !== $this->createFromTimeGMT) {
            $res['createFromTimeGMT'] = $this->createFromTimeGMT;
        }
        if (null !== $this->createToTimeGMT) {
            $res['createToTimeGMT'] = $this->createToTimeGMT;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->instanceStatus) {
            $res['instanceStatus'] = $this->instanceStatus;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->modifiedFromTimeGMT) {
            $res['modifiedFromTimeGMT'] = $this->modifiedFromTimeGMT;
        }
        if (null !== $this->modifiedToTimeGMT) {
            $res['modifiedToTimeGMT'] = $this->modifiedToTimeGMT;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->searchFieldJson) {
            $res['searchFieldJson'] = $this->searchFieldJson;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInstanceIdListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['approvedResult'])) {
            $model->approvedResult = $map['approvedResult'];
        }
        if (isset($map['createFromTimeGMT'])) {
            $model->createFromTimeGMT = $map['createFromTimeGMT'];
        }
        if (isset($map['createToTimeGMT'])) {
            $model->createToTimeGMT = $map['createToTimeGMT'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['instanceStatus'])) {
            $model->instanceStatus = $map['instanceStatus'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['modifiedFromTimeGMT'])) {
            $model->modifiedFromTimeGMT = $map['modifiedFromTimeGMT'];
        }
        if (isset($map['modifiedToTimeGMT'])) {
            $model->modifiedToTimeGMT = $map['modifiedToTimeGMT'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['searchFieldJson'])) {
            $model->searchFieldJson = $map['searchFieldJson'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
