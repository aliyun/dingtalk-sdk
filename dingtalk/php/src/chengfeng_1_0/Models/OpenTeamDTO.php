<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenTeamDTO extends Model
{
    /**
     * @example 1
     *
     * @var string
     */
    public $id;

    /**
     * @example 销售部
     *
     * @var string
     */
    public $name;

    /**
     * @example 30211
     *
     * @var string
     */
    public $openId;
    protected $_name = [
        'id'     => 'id',
        'name'   => 'name',
        'openId' => 'openId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->openId) {
            $res['openId'] = $this->openId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenTeamDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['openId'])) {
            $model->openId = $map['openId'];
        }

        return $model;
    }
}
