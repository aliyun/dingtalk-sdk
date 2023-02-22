<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListInnerAppVersionResponseBody\appVersionList;
use AlibabaCloud\Tea\Model;

class ListInnerAppVersionResponseBody extends Model
{
    /**
     * @description 企业内部小程序版本号列表
     *
     * @var appVersionList[]
     */
    public $appVersionList;
    protected $_name = [
        'appVersionList' => 'appVersionList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appVersionList) {
            $res['appVersionList'] = [];
            if (null !== $this->appVersionList && \is_array($this->appVersionList)) {
                $n = 0;
                foreach ($this->appVersionList as $item) {
                    $res['appVersionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListInnerAppVersionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appVersionList'])) {
            if (!empty($map['appVersionList'])) {
                $model->appVersionList = [];
                $n                     = 0;
                foreach ($map['appVersionList'] as $item) {
                    $model->appVersionList[$n++] = null !== $item ? appVersionList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
