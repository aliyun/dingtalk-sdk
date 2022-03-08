<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\CorpInfoResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $orgRealName;

    /**
     * @var bool
     */
    public $realName;
    protected $_name = [
        'orgRealName' => 'orgRealName',
        'realName'    => 'realName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orgRealName) {
            $res['orgRealName'] = $this->orgRealName;
        }
        if (null !== $this->realName) {
            $res['realName'] = $this->realName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orgRealName'])) {
            $model->orgRealName = $map['orgRealName'];
        }
        if (isset($map['realName'])) {
            $model->realName = $map['realName'];
        }

        return $model;
    }
}
