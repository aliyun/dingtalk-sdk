<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class MultiOrgPermissionGrantRequest extends Model
{
    /**
     * @description 授权加入的组织corpId
     *
     * @var string
     */
    public $joinCorpId;
    protected $_name = [
        'joinCorpId' => 'joinCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (isset($map['joinCorpId'])) {
            $model->joinCorpId = $map['joinCorpId'];
        }

        return $model;
    }
}
