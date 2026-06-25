<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\GetSkillDetailResponseBody\categories;
use AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\GetSkillDetailResponseBody\dependencies;
use AlibabaCloud\Tea\Model;

class GetSkillDetailResponseBody extends Model
{
    /**
     * @var categories[]
     */
    public $categories;

    /**
     * @var dependencies[]
     */
    public $dependencies;

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
    public $introduction;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $packageUrl;

    /**
     * @var string
     */
    public $skillId;
    protected $_name = [
        'categories' => 'categories',
        'dependencies' => 'dependencies',
        'description' => 'description',
        'detailUrl' => 'detailUrl',
        'icon' => 'icon',
        'introduction' => 'introduction',
        'name' => 'name',
        'packageUrl' => 'packageUrl',
        'skillId' => 'skillId',
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
        if (null !== $this->dependencies) {
            $res['dependencies'] = [];
            if (null !== $this->dependencies && \is_array($this->dependencies)) {
                $n = 0;
                foreach ($this->dependencies as $item) {
                    $res['dependencies'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->packageUrl) {
            $res['packageUrl'] = $this->packageUrl;
        }
        if (null !== $this->skillId) {
            $res['skillId'] = $this->skillId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSkillDetailResponseBody
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
        if (isset($map['dependencies'])) {
            if (!empty($map['dependencies'])) {
                $model->dependencies = [];
                $n = 0;
                foreach ($map['dependencies'] as $item) {
                    $model->dependencies[$n++] = null !== $item ? dependencies::fromMap($item) : $item;
                }
            }
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
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['packageUrl'])) {
            $model->packageUrl = $map['packageUrl'];
        }
        if (isset($map['skillId'])) {
            $model->skillId = $map['skillId'];
        }

        return $model;
    }
}
