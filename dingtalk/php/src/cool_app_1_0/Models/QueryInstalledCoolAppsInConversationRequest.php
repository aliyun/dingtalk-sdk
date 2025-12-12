<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryInstalledCoolAppsInConversationRequest extends Model
{
    /**
     * @example cidxxx
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryInstalledCoolAppsInConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
