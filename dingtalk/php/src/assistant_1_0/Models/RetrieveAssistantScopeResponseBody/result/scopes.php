<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\RetrieveAssistantScopeResponseBody\result;

use AlibabaCloud\Tea\Model;

class scopes extends Model
{
    /**
     * @var string[]
     */
    public $deptVisibleScopes;

    /**
     * @var string[]
     */
    public $dynamicGroupScopes;

    /**
     * @var bool
     */
    public $isAdmin;

    /**
     * @var string[]
     */
    public $roleVisibleScopes;

    /**
     * @var string[]
     */
    public $userVisibleScopes;
    protected $_name = [
        'deptVisibleScopes'  => 'deptVisibleScopes',
        'dynamicGroupScopes' => 'dynamicGroupScopes',
        'isAdmin'            => 'isAdmin',
        'roleVisibleScopes'  => 'roleVisibleScopes',
        'userVisibleScopes'  => 'userVisibleScopes',
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
        if (null !== $this->dynamicGroupScopes) {
            $res['dynamicGroupScopes'] = $this->dynamicGroupScopes;
        }
        if (null !== $this->isAdmin) {
            $res['isAdmin'] = $this->isAdmin;
        }
        if (null !== $this->roleVisibleScopes) {
            $res['roleVisibleScopes'] = $this->roleVisibleScopes;
        }
        if (null !== $this->userVisibleScopes) {
            $res['userVisibleScopes'] = $this->userVisibleScopes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scopes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptVisibleScopes'])) {
            if (!empty($map['deptVisibleScopes'])) {
                $model->deptVisibleScopes = $map['deptVisibleScopes'];
            }
        }
        if (isset($map['dynamicGroupScopes'])) {
            if (!empty($map['dynamicGroupScopes'])) {
                $model->dynamicGroupScopes = $map['dynamicGroupScopes'];
            }
        }
        if (isset($map['isAdmin'])) {
            $model->isAdmin = $map['isAdmin'];
        }
        if (isset($map['roleVisibleScopes'])) {
            if (!empty($map['roleVisibleScopes'])) {
                $model->roleVisibleScopes = $map['roleVisibleScopes'];
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
