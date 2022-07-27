<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_\openAction;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_\openAction\openCondition\openContactScope;
use AlibabaCloud\Tea\Model;

class openCondition extends Model
{
    /**
     * @var openContactScope
     */
    public $openContactScope;
    protected $_name = [
        'openContactScope' => 'openContactScope',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openContactScope) {
            $res['openContactScope'] = null !== $this->openContactScope ? $this->openContactScope->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openCondition
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openContactScope'])) {
            $model->openContactScope = openContactScope::fromMap($map['openContactScope']);
        }

        return $model;
    }
}
