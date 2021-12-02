<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody\authAppInfo\agentList;
use AlibabaCloud\Tea\Model;

class authAppInfo extends Model
{
    /**
     * @var agentList[]
     */
    public $agentList;
    protected $_name = [
        'agentList' => 'agentList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentList) {
            $res['agentList'] = [];
            if (null !== $this->agentList && \is_array($this->agentList)) {
                $n = 0;
                foreach ($this->agentList as $item) {
                    $res['agentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return authAppInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentList'])) {
            if (!empty($map['agentList'])) {
                $model->agentList = [];
                $n                = 0;
                foreach ($map['agentList'] as $item) {
                    $model->agentList[$n++] = null !== $item ? agentList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
