<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class DelAccountMappingRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example BizName1
     *
     * @var string
     */
    public $domain;

    /**
     * @description This parameter is required.
     *
     * @example id_123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'domain' => 'domain',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->domain) {
            $res['domain'] = $this->domain;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DelAccountMappingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain'])) {
            $model->domain = $map['domain'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
