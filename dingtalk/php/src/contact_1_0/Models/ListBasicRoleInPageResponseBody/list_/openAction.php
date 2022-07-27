<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_\openAction\openCondition;
use AlibabaCloud\Tea\Model;

class openAction extends Model
{
    /**
     * @var string[]
     */
    public $actionIds;

    /**
     * @var openCondition
     */
    public $openCondition;
    protected $_name = [
        'actionIds'     => 'actionIds',
        'openCondition' => 'openCondition',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionIds) {
            $res['actionIds'] = $this->actionIds;
        }
        if (null !== $this->openCondition) {
            $res['openCondition'] = null !== $this->openCondition ? $this->openCondition->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openAction
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionIds'])) {
            if (!empty($map['actionIds'])) {
                $model->actionIds = $map['actionIds'];
            }
        }
        if (isset($map['openCondition'])) {
            $model->openCondition = openCondition::fromMap($map['openCondition']);
        }

        return $model;
    }
}
