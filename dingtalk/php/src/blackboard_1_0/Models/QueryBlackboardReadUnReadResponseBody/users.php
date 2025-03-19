<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\QueryBlackboardReadUnReadResponseBody;

use AlibabaCloud\Tea\Model;

class users extends Model
{
    /**
     * @example true
     *
     * @var string
     */
    public $read;

    /**
     * @var int
     */
    public $readTimestamp;

    /**
     * @example 12039
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'read' => 'read',
        'readTimestamp' => 'readTimestamp',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->read) {
            $res['read'] = $this->read;
        }
        if (null !== $this->readTimestamp) {
            $res['readTimestamp'] = $this->readTimestamp;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return users
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['read'])) {
            $model->read = $map['read'];
        }
        if (isset($map['readTimestamp'])) {
            $model->readTimestamp = $map['readTimestamp'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
