<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\LoginForVisitorResponseBody;

use AlibabaCloud\Tea\Model;

class aimInfo extends Model
{
    /**
     * @var mixed[]
     */
    public $appKey;

    /**
     * @var string
     */
    public $appName;
    protected $_name = [
        'appKey' => 'appKey',
        'appName' => 'appName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aimInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }

        return $model;
    }
}
