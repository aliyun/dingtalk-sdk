<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\DeployAssistantRequest;

use AlibabaCloud\Tea\Model;

class appScopes extends Model
{
    /**
     * @var string
     */
    public $deptVisibleScopes;

    /**
     * @var string
     */
    public $dynamicGroupScopes;

    /**
     * @var bool
     */
    public $isHidden;

    /**
     * @var string
     */
    public $roleVisibleScopes;

    /**
     * @var string
     */
    public $userVisibleScopes;
    protected $_name = [
        'deptVisibleScopes' => 'deptVisibleScopes',
        'dynamicGroupScopes' => 'dynamicGroupScopes',
        'isHidden' => 'isHidden',
        'roleVisibleScopes' => 'roleVisibleScopes',
        'userVisibleScopes' => 'userVisibleScopes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptVisibleScopes) {
            $res['deptVisibleScopes'] = $this->deptVisibleScopes;
        }
        if (null !== $this->dynamicGroupScopes) {
            $res['dynamicGroupScopes'] = $this->dynamicGroupScopes;
        }
        if (null !== $this->isHidden) {
            $res['isHidden'] = $this->isHidden;
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
     * @return appScopes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptVisibleScopes'])) {
            $model->deptVisibleScopes = $map['deptVisibleScopes'];
        }
        if (isset($map['dynamicGroupScopes'])) {
            $model->dynamicGroupScopes = $map['dynamicGroupScopes'];
        }
        if (isset($map['isHidden'])) {
            $model->isHidden = $map['isHidden'];
        }
        if (isset($map['roleVisibleScopes'])) {
            $model->roleVisibleScopes = $map['roleVisibleScopes'];
        }
        if (isset($map['userVisibleScopes'])) {
            $model->userVisibleScopes = $map['userVisibleScopes'];
        }

        return $model;
    }
}
