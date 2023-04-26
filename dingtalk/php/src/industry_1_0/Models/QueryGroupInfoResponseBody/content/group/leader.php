<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody\content\group;

use AlibabaCloud\Tea\Model;

class leader extends Model
{
    /**
     * @example 3212
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example 1234
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'jobNumber' => 'jobNumber',
        'name'      => 'name',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return leader
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
