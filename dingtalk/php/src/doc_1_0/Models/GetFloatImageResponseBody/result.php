<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetFloatImageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetFloatImageResponseBody\result\anchor;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetFloatImageResponseBody\result\coordinate;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var anchor
     */
    public $anchor;

    /**
     * @var coordinate
     */
    public $coordinate;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $src;
    protected $_name = [
        'anchor' => 'anchor',
        'coordinate' => 'coordinate',
        'id' => 'id',
        'src' => 'src',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->anchor) {
            $res['anchor'] = null !== $this->anchor ? $this->anchor->toMap() : null;
        }
        if (null !== $this->coordinate) {
            $res['coordinate'] = null !== $this->coordinate ? $this->coordinate->toMap() : null;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->src) {
            $res['src'] = $this->src;
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
        if (isset($map['anchor'])) {
            $model->anchor = anchor::fromMap($map['anchor']);
        }
        if (isset($map['coordinate'])) {
            $model->coordinate = coordinate::fromMap($map['coordinate']);
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['src'])) {
            $model->src = $map['src'];
        }

        return $model;
    }
}
