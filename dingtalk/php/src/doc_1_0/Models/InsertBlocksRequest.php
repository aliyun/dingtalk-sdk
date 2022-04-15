<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\location;
use AlibabaCloud\Tea\Model;

class InsertBlocksRequest extends Model
{
    /**
     * @description 元素数组
     *
     * @var blocks[]
     */
    public $blocks;

    /**
     * @description 位置信息
     *
     * @var location
     */
    public $location;

    /**
     * @description 操作用户unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'blocks'     => 'blocks',
        'location'   => 'location',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blocks) {
            $res['blocks'] = [];
            if (null !== $this->blocks && \is_array($this->blocks)) {
                $n = 0;
                foreach ($this->blocks as $item) {
                    $res['blocks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->location) {
            $res['location'] = null !== $this->location ? $this->location->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InsertBlocksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blocks'])) {
            if (!empty($map['blocks'])) {
                $model->blocks = [];
                $n             = 0;
                foreach ($map['blocks'] as $item) {
                    $model->blocks[$n++] = null !== $item ? blocks::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['location'])) {
            $model->location = location::fromMap($map['location']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
