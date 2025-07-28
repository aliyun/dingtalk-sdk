<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class TitleMention extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $length;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $offset;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $user;
    protected $_name = [
        'length' => 'length',
        'offset' => 'offset',
        'user' => 'user',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->length) {
            $res['length'] = $this->length;
        }
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->user) {
            $res['user'] = null !== $this->user ? $this->user->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TitleMention
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['length'])) {
            $model->length = $map['length'];
        }
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['user'])) {
            $model->user = OpenAgoalUserDTO::fromMap($map['user']);
        }

        return $model;
    }
}
