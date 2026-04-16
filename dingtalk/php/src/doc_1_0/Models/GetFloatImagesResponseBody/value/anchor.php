<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetFloatImagesResponseBody\value;

use AlibabaCloud\Tea\Model;

class anchor extends Model
{
    /**
     * @var int
     */
    public $col;

    /**
     * @var int
     */
    public $row;
    protected $_name = [
        'col' => 'col',
        'row' => 'row',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->col) {
            $res['col'] = $this->col;
        }
        if (null !== $this->row) {
            $res['row'] = $this->row;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return anchor
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['col'])) {
            $model->col = $map['col'];
        }
        if (isset($map['row'])) {
            $model->row = $map['row'];
        }

        return $model;
    }
}
