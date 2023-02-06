<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class WearOrgHonorRequest extends Model
{
    /**
     * @description 员工userid
     *
     * @var string
     */
    public $userId;

    /**
     * @description 佩戴true，卸下false
     *
     * @var bool
     */
    public $wear;
    protected $_name = [
        'userId' => 'userId',
        'wear'   => 'wear',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->wear) {
            $res['wear'] = $this->wear;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WearOrgHonorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['wear'])) {
            $model->wear = $map['wear'];
        }

        return $model;
    }
}
