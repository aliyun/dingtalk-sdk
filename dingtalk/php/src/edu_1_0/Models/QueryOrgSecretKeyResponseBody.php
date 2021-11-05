<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgSecretKeyResponseBody\universitySecretKeyInfo;
use AlibabaCloud\Tea\Model;

class QueryOrgSecretKeyResponseBody extends Model
{
    /**
     * @description 秘钥信息
     *
     * @var universitySecretKeyInfo
     */
    public $universitySecretKeyInfo;
    protected $_name = [
        'universitySecretKeyInfo' => 'universitySecretKeyInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->universitySecretKeyInfo) {
            $res['universitySecretKeyInfo'] = null !== $this->universitySecretKeyInfo ? $this->universitySecretKeyInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOrgSecretKeyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['universitySecretKeyInfo'])) {
            $model->universitySecretKeyInfo = universitySecretKeyInfo::fromMap($map['universitySecretKeyInfo']);
        }

        return $model;
    }
}
