<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models\QueryInstalledCoolAppsInConversationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models\QueryInstalledCoolAppsInConversationResponseBody\result\coolApps;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var coolApps[]
     */
    public $coolApps;
    protected $_name = [
        'coolApps' => 'coolApps',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolApps) {
            $res['coolApps'] = [];
            if (null !== $this->coolApps && \is_array($this->coolApps)) {
                $n = 0;
                foreach ($this->coolApps as $item) {
                    $res['coolApps'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['coolApps'])) {
            if (!empty($map['coolApps'])) {
                $model->coolApps = [];
                $n = 0;
                foreach ($map['coolApps'] as $item) {
                    $model->coolApps[$n++] = null !== $item ? coolApps::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
