<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetAgentTasksRequest extends Model
{
    /**
     * @example Agent--XXXXX
     *
     * @var string
     */
    public $agentUuid;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 10001
     *
     * @var string
     */
    public $keywords;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example ALL
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $token;

    /**
     * @description This parameter is required.
     *
     * @example 501453
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'agentUuid' => 'agentUuid',
        'corpId' => 'corpId',
        'keywords' => 'keywords',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'status' => 'status',
        'token' => 'token',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentUuid) {
            $res['agentUuid'] = $this->agentUuid;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->keywords) {
            $res['keywords'] = $this->keywords;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAgentTasksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentUuid'])) {
            $model->agentUuid = $map['agentUuid'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['keywords'])) {
            $model->keywords = $map['keywords'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
