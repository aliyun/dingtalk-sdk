<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetDingPortalDetailResponseBody\pages;
use AlibabaCloud\Tea\Model;

class GetDingPortalDetailResponseBody extends Model
{
    /**
     * @description 工作台ID
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 工作台名称
     *
     * @var string
     */
    public $dingPortalName;

    /**
     * @description 工作台页面信息
     *
     * @var pages[]
     */
    public $pages;
    protected $_name = [
        'appUuid'        => 'appUuid',
        'dingPortalName' => 'dingPortalName',
        'pages'          => 'pages',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->dingPortalName) {
            $res['dingPortalName'] = $this->dingPortalName;
        }
        if (null !== $this->pages) {
            $res['pages'] = [];
            if (null !== $this->pages && \is_array($this->pages)) {
                $n = 0;
                foreach ($this->pages as $item) {
                    $res['pages'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDingPortalDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['dingPortalName'])) {
            $model->dingPortalName = $map['dingPortalName'];
        }
        if (isset($map['pages'])) {
            if (!empty($map['pages'])) {
                $model->pages = [];
                $n            = 0;
                foreach ($map['pages'] as $item) {
                    $model->pages[$n++] = null !== $item ? pages::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
