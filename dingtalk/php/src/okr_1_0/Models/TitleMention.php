<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class TitleMention extends Model
{
    /**
     * @example 20
     *
     * @var int
     */
    public $length;

    /**
     * @example 1
     *
     * @var int
     */
    public $offset;

    /**
     * @var OpenUserDTO
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
            $model->user = OpenUserDTO::fromMap($map['user']);
        }

        return $model;
    }
}
