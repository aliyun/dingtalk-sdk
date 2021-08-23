<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSimpleUsersByRoleResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $jobNumber;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'userId'    => 'userId',
        'unionId'   => 'unionId',
        'jobNumber' => 'jobNumber',
        'name'      => 'name',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
