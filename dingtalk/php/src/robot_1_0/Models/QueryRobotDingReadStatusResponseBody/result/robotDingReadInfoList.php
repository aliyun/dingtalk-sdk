<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\QueryRobotDingReadStatusResponseBody\result;

use AlibabaCloud\Tea\Model;

class robotDingReadInfoList extends Model
{
    /**
     * @var string
     */
    public $readStatus;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'readStatus' => 'readStatus',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->readStatus) {
            $res['readStatus'] = $this->readStatus;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return robotDingReadInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['readStatus'])) {
            $model->readStatus = $map['readStatus'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
