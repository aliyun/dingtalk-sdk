<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetCidsByBotCodeResponseBody;

use AlibabaCloud\Tea\Model;

class groupInfos extends Model
{
    /**
     * @var string
     */
    public $botCreator;

    /**
     * @var bool
     */
    public $botCreatorIsOrgMember;

    /**
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'botCreator' => 'botCreator',
        'botCreatorIsOrgMember' => 'botCreatorIsOrgMember',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->botCreator) {
            $res['botCreator'] = $this->botCreator;
        }
        if (null !== $this->botCreatorIsOrgMember) {
            $res['botCreatorIsOrgMember'] = $this->botCreatorIsOrgMember;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['botCreator'])) {
            $model->botCreator = $map['botCreator'];
        }
        if (isset($map['botCreatorIsOrgMember'])) {
            $model->botCreatorIsOrgMember = $map['botCreatorIsOrgMember'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
