<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatAIQueryDatasetPermissionResponseBody\permissionInfos;
use AlibabaCloud\Tea\Model;

class ChatAIQueryDatasetPermissionResponseBody extends Model
{
    /**
     * @var permissionInfos[]
     */
    public $permissionInfos;
    protected $_name = [
        'permissionInfos' => 'permissionInfos',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionInfos) {
            $res['permissionInfos'] = [];
            if (null !== $this->permissionInfos && \is_array($this->permissionInfos)) {
                $n = 0;
                foreach ($this->permissionInfos as $item) {
                    $res['permissionInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatAIQueryDatasetPermissionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionInfos'])) {
            if (!empty($map['permissionInfos'])) {
                $model->permissionInfos = [];
                $n = 0;
                foreach ($map['permissionInfos'] as $item) {
                    $model->permissionInfos[$n++] = null !== $item ? permissionInfos::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
