<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SpaceModel;

use AlibabaCloud\Tea\Model;

class visitorInfo extends Model
{
    /**
     * @var string[]
     */
    public $dentryActions;

    /**
     * @example 3
     *
     * @var string
     */
    public $roleCode;

    /**
     * @var string[]
     */
    public $spaceActions;
    protected $_name = [
        'dentryActions' => 'dentryActions',
        'roleCode' => 'roleCode',
        'spaceActions' => 'spaceActions',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryActions) {
            $res['dentryActions'] = $this->dentryActions;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->spaceActions) {
            $res['spaceActions'] = $this->spaceActions;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return visitorInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryActions'])) {
            if (!empty($map['dentryActions'])) {
                $model->dentryActions = $map['dentryActions'];
            }
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['spaceActions'])) {
            if (!empty($map['spaceActions'])) {
                $model->spaceActions = $map['spaceActions'];
            }
        }

        return $model;
    }
}
