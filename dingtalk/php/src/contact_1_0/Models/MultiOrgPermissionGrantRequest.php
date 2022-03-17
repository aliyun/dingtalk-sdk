<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class MultiOrgPermissionGrantRequest extends Model
{
    /**
     * @description 被授权的部门，如果不填则默认全组织
     *
     * @var int[]
     */
    public $grantDeptIdList;

    /**
     * @description 授权加入的组织corpId
     *
     * @var string
     */
    public $joinCorpId;
    protected $_name = [
        'grantDeptIdList' => 'grantDeptIdList',
        'joinCorpId'      => 'joinCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->grantDeptIdList) {
            $res['grantDeptIdList'] = $this->grantDeptIdList;
        }
        if (null !== $this->joinCorpId) {
            $res['joinCorpId'] = $this->joinCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MultiOrgPermissionGrantRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['grantDeptIdList'])) {
            if (!empty($map['grantDeptIdList'])) {
                $model->grantDeptIdList = $map['grantDeptIdList'];
            }
        }
        if (isset($map['joinCorpId'])) {
            $model->joinCorpId = $map['joinCorpId'];
        }

        return $model;
    }
}
