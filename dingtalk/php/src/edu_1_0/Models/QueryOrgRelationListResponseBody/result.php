<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgRelationListResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $deviceCount;
    protected $_name = [
        'corpId'      => 'corpId',
        'name'        => 'name',
        'deviceCount' => 'deviceCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->deviceCount) {
            $res['deviceCount'] = $this->deviceCount;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['deviceCount'])) {
            $model->deviceCount = $map['deviceCount'];
        }

        return $model;
    }
}
