<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryServiceRecordRequest extends Model
{
    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 服务类型
     *
     * @var string
     */
    public $hookType;

    /**
     * @description 本次服务调用的唯一ID
     *
     * @var string
     */
    public $hookUuid;

    /**
     * @description 表单实例ID
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 服务在此时间之后调用的
     *
     * @var string
     */
    public $invokeAfterDateGMT;

    /**
     * @description 服务在此时间之前调用的
     *
     * @var string
     */
    public $invokeBeforeDateGMT;

    /**
     * @description 服务调用状态
     *
     * @var string
     */
    public $invokeStatus;

    /**
     * @description 分页第几页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 服务调用地址包含的部分字符串，用于模糊搜索
     *
     * @var string
     */
    public $requestUrl;

    /**
     * @description 被重试的服务调用唯一ID(此次服务调用是重试哪个执行失败的服务调用)
     *
     * @var string
     */
    public $sourceUuid;

    /**
     * @description 服务调用是否成功(不传此参数则查询全部的)
     *
     * @var bool
     */
    public $success;

    /**
     * @description 宜搭应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 操作人的钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'             => 'appType',
        'formUuid'            => 'formUuid',
        'hookType'            => 'hookType',
        'hookUuid'            => 'hookUuid',
        'instanceId'          => 'instanceId',
        'invokeAfterDateGMT'  => 'invokeAfterDateGMT',
        'invokeBeforeDateGMT' => 'invokeBeforeDateGMT',
        'invokeStatus'        => 'invokeStatus',
        'pageNumber'          => 'pageNumber',
        'pageSize'            => 'pageSize',
        'requestUrl'          => 'requestUrl',
        'sourceUuid'          => 'sourceUuid',
        'success'             => 'success',
        'systemToken'         => 'systemToken',
        'userId'              => 'userId',
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
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->hookType) {
            $res['hookType'] = $this->hookType;
        }
        if (null !== $this->hookUuid) {
            $res['hookUuid'] = $this->hookUuid;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->invokeAfterDateGMT) {
            $res['invokeAfterDateGMT'] = $this->invokeAfterDateGMT;
        }
        if (null !== $this->invokeBeforeDateGMT) {
            $res['invokeBeforeDateGMT'] = $this->invokeBeforeDateGMT;
        }
        if (null !== $this->invokeStatus) {
            $res['invokeStatus'] = $this->invokeStatus;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->requestUrl) {
            $res['requestUrl'] = $this->requestUrl;
        }
        if (null !== $this->sourceUuid) {
            $res['sourceUuid'] = $this->sourceUuid;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryServiceRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['hookType'])) {
            $model->hookType = $map['hookType'];
        }
        if (isset($map['hookUuid'])) {
            $model->hookUuid = $map['hookUuid'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['invokeAfterDateGMT'])) {
            $model->invokeAfterDateGMT = $map['invokeAfterDateGMT'];
        }
        if (isset($map['invokeBeforeDateGMT'])) {
            $model->invokeBeforeDateGMT = $map['invokeBeforeDateGMT'];
        }
        if (isset($map['invokeStatus'])) {
            $model->invokeStatus = $map['invokeStatus'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['requestUrl'])) {
            $model->requestUrl = $map['requestUrl'];
        }
        if (isset($map['sourceUuid'])) {
            $model->sourceUuid = $map['sourceUuid'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
