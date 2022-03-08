<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryComponentScopesResponseBody extends Model
{
    /**
     * @var int[]
     */
    public $deptVisibleScopes;

    /**
     * @description scopes
     *
     * @var string[]
     */
    public $userVisibleScopes;
    protected $_name = [
        'deptVisibleScopes' => 'deptVisibleScopes',
        'userVisibleScopes' => 'userVisibleScopes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptVisibleScopes) {
            $res['deptVisibleScopes'] = $this->deptVisibleScopes;
        }
        if (null !== $this->userVisibleScopes) {
            $res['userVisibleScopes'] = $this->userVisibleScopes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryComponentScopesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptVisibleScopes'])) {
            if (!empty($map['deptVisibleScopes'])) {
                $model->deptVisibleScopes = $map['deptVisibleScopes'];
            }
        }
        if (isset($map['userVisibleScopes'])) {
            if (!empty($map['userVisibleScopes'])) {
                $model->userVisibleScopes = $map['userVisibleScopes'];
            }
        }

        return $model;
    }
}
