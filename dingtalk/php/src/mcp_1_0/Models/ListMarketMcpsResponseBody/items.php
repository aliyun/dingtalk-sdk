<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListMarketMcpsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\ListMarketMcpsResponseBody\items\categories;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var categories[]
     */
    public $categories;

    /**
     * @var bool
     */
    public $charged;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $detailUrl;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var string
     */
    public $mcpId;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'categories' => 'categories',
        'charged' => 'charged',
        'description' => 'description',
        'detailUrl' => 'detailUrl',
        'icon' => 'icon',
        'mcpId' => 'mcpId',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->categories) {
            $res['categories'] = [];
            if (null !== $this->categories && \is_array($this->categories)) {
                $n = 0;
                foreach ($this->categories as $item) {
                    $res['categories'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->charged) {
            $res['charged'] = $this->charged;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = $this->detailUrl;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->mcpId) {
            $res['mcpId'] = $this->mcpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categories'])) {
            if (!empty($map['categories'])) {
                $model->categories = [];
                $n = 0;
                foreach ($map['categories'] as $item) {
                    $model->categories[$n++] = null !== $item ? categories::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['charged'])) {
            $model->charged = $map['charged'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = $map['detailUrl'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['mcpId'])) {
            $model->mcpId = $map['mcpId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
