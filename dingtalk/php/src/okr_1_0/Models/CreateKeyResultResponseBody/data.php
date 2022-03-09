<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateKeyResultResponseBody;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class data extends Model
{
    /**
     * @var Stream
     */
    public $id;

    /**
     * @var int
     */
    public $position;

    /**
     * @var int
     */
    public $weight;
    protected $_name = [
        'id'       => 'id',
        'position' => 'position',
        'weight'   => 'weight',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }
        if (null !== $this->weight) {
            $res['weight'] = $this->weight;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }
        if (isset($map['weight'])) {
            $model->weight = $map['weight'];
        }

        return $model;
    }
}
