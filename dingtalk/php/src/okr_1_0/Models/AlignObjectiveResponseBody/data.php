<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\AlignObjectiveResponseBody;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class data extends Model
{
    /**
     * @example 59YD
     *
     * @var Stream
     */
    public $alignId;

    /**
     * @example 5dAX8
     *
     * @var Stream
     */
    public $id;
    protected $_name = [
        'alignId' => 'alignId',
        'id'      => 'id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alignId) {
            $res['alignId'] = $this->alignId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alignId'])) {
            $model->alignId = $map['alignId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
