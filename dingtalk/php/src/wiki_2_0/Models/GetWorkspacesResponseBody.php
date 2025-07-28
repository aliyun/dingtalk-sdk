<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspacesResponseBody\workspaces;
use AlibabaCloud\Tea\Model;

class GetWorkspacesResponseBody extends Model
{
    /**
     * @var workspaces[]
     */
    public $workspaces;
    protected $_name = [
        'workspaces' => 'workspaces',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->workspaces) {
            $res['workspaces'] = [];
            if (null !== $this->workspaces && \is_array($this->workspaces)) {
                $n = 0;
                foreach ($this->workspaces as $item) {
                    $res['workspaces'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWorkspacesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workspaces'])) {
            if (!empty($map['workspaces'])) {
                $model->workspaces = [];
                $n = 0;
                foreach ($map['workspaces'] as $item) {
                    $model->workspaces[$n++] = null !== $item ? workspaces::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
