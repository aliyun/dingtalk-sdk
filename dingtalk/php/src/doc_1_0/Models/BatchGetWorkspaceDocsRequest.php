<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetWorkspaceDocsRequest extends Model
{
    /**
     * @description 操作用户unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 查询节点Id
     *
     * @var string[]
     */
    public $nodeIds;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingAccessTokenType;

    /**
     * @var int
     */
    public $dingUid;
    protected $_name = [
        'operatorId'          => 'operatorId',
        'nodeIds'             => 'nodeIds',
        'dingIsvOrgId'        => 'dingIsvOrgId',
        'dingOrgId'           => 'dingOrgId',
        'dingAccessTokenType' => 'dingAccessTokenType',
        'dingUid'             => 'dingUid',
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
        if (null !== $this->nodeIds) {
            $res['nodeIds'] = $this->nodeIds;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingAccessTokenType) {
            $res['dingAccessTokenType'] = $this->dingAccessTokenType;
        }
        if (null !== $this->dingUid) {
            $res['dingUid'] = $this->dingUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetWorkspaceDocsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['nodeIds'])) {
            if (!empty($map['nodeIds'])) {
                $model->nodeIds = $map['nodeIds'];
            }
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingAccessTokenType'])) {
            $model->dingAccessTokenType = $map['dingAccessTokenType'];
        }
        if (isset($map['dingUid'])) {
            $model->dingUid = $map['dingUid'];
        }

        return $model;
    }
}
