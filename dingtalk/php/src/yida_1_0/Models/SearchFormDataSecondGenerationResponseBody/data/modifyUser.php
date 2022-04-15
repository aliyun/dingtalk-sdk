<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataSecondGenerationResponseBody\data\modifyUser\name;
use AlibabaCloud\Tea\Model;

class modifyUser extends Model
{
    /**
     * @description 名称
     *
     * @var name
     */
    public $name;

    /**
     * @description 钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'   => 'name',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return modifyUser
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
