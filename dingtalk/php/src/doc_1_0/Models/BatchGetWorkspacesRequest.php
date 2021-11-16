<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetWorkspacesRequest extends Model
{
    /**
     * @description 操作用户unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 是否查询最近访问文档
     *
     * @var bool
     */
    public $includeRecent;

    /**
     * @description 待查询空间Id
     *
     * @var string[]
     */
    public $workspaceIds;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingUid;

    /**
     * @var string
     */
    public $dingAccessTokenType;
    protected $_name = [
        'operatorId'          => 'operatorId',
        'includeRecent'       => 'includeRecent',
        'workspaceIds'        => 'workspaceIds',
        'dingOrgId'           => 'dingOrgId',
        'dingIsvOrgId'        => 'dingIsvOrgId',
        'dingUid'             => 'dingUid',
        'dingAccessTokenType' => 'dingAccessTokenType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->includeRecent) {
            $res['includeRecent'] = $this->includeRecent;
        }
        if (null !== $this->workspaceIds) {
            $res['workspaceIds'] = $this->workspaceIds;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingUid) {
            $res['dingUid'] = $this->dingUid;
        }
        if (null !== $this->dingAccessTokenType) {
            $res['dingAccessTokenType'] = $this->dingAccessTokenType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetWorkspacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['includeRecent'])) {
            $model->includeRecent = $map['includeRecent'];
        }
        if (isset($map['workspaceIds'])) {
            if (!empty($map['workspaceIds'])) {
                $model->workspaceIds = $map['workspaceIds'];
            }
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingUid'])) {
            $model->dingUid = $map['dingUid'];
        }
        if (isset($map['dingAccessTokenType'])) {
            $model->dingAccessTokenType = $map['dingAccessTokenType'];
        }

        return $model;
    }
}
