<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateFloatImageRequest\anchor;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\UpdateFloatImageRequest\coordinate;
use AlibabaCloud\Tea\Model;

class UpdateFloatImageRequest extends Model
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
    public $src;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'anchor' => 'anchor',
        'coordinate' => 'coordinate',
        'src' => 'src',
        'operatorId' => 'operatorId',
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
        if (null !== $this->src) {
            $res['src'] = $this->src;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFloatImageRequest
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
        if (isset($map['src'])) {
            $model->src = $map['src'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
