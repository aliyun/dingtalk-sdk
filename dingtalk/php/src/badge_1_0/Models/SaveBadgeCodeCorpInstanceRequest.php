<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveBadgeCodeCorpInstanceRequest extends Model
{
    /**
     * @description 码标识，由钉钉颁发
     *
     * @var string
     */
    public $codeIdentity;

    /**
     * @description 开通的企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 状态，OPEN或CLOSED
     *
     * @var string
     */
    public $status;

    /**
     * @description 扩展参数
     *
     * @var string[]
     */
    public $extInfo;

    /**
     * @description 组织ID
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description ISV组织ID
     *
     * @var int
     */
    public $dingIsvOrgId;
    protected $_name = [
        'codeIdentity' => 'codeIdentity',
        'corpId'       => 'corpId',
        'status'       => 'status',
        'extInfo'      => 'extInfo',
        'dingOrgId'    => 'dingOrgId',
        'dingIsvOrgId' => 'dingIsvOrgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->codeIdentity) {
            $res['codeIdentity'] = $this->codeIdentity;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveBadgeCodeCorpInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codeIdentity'])) {
            $model->codeIdentity = $map['codeIdentity'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }

        return $model;
    }
}
