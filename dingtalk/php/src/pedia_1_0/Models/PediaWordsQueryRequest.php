<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models;

use AlibabaCloud\Tea\Model;

class PediaWordsQueryRequest extends Model
{
    /**
     * @example 212121
     *
     * @var string
     */
    public $userId;

    /**
     * @example 211121
     *
     * @var int
     */
    public $uuid;
    protected $_name = [
        'userId' => 'userId',
        'uuid'   => 'uuid',
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
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PediaWordsQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
