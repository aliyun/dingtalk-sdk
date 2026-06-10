<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListRecentsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListRecentsResponseBody\recentDentryList\resource;
use AlibabaCloud\Tea\Model;

class recentDentryList extends Model
{
    /**
     * @var int
     */
    public $accessTime;

    /**
     * @var bool
     */
    public $deleted;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var int
     */
    public $operateType;

    /**
     * @var resource
     */
    public $resource;
    protected $_name = [
        'accessTime' => 'accessTime',
        'deleted' => 'deleted',
        'icon' => 'icon',
        'operateType' => 'operateType',
        'resource' => 'resource',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessTime) {
            $res['accessTime'] = $this->accessTime;
        }
        if (null !== $this->deleted) {
            $res['deleted'] = $this->deleted;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
        }
        if (null !== $this->resource) {
            $res['resource'] = null !== $this->resource ? $this->resource->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recentDentryList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessTime'])) {
            $model->accessTime = $map['accessTime'];
        }
        if (isset($map['deleted'])) {
            $model->deleted = $map['deleted'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
        }
        if (isset($map['resource'])) {
            $model->resource = resource::fromMap($map['resource']);
        }

        return $model;
    }
}
