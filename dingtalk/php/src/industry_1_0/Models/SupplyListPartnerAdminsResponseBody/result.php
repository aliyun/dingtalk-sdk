<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyListPartnerAdminsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 负责人名称
     *
     * @var string
     */
    public $name;

    /**
     * @example 99292111
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 8782166278711
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'    => 'name',
        'unionId' => 'unionId',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
