<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\ConvertUnionIdResponseBody\result;

use AlibabaCloud\Tea\Model;

class isvUserUnionIdVOList extends Model
{
    /**
     * @example unionId123
     *
     * @var string
     */
    public $unionId;

    /**
     * @example userId123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'unionId' => 'unionId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
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
     * @return isvUserUnionIdVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
