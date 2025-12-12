<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models\QueryInstalledCoolAppsInConversationResponseBody\result;

use AlibabaCloud\Tea\Model;

class coolApps extends Model
{
    /**
     * @var string
     */
    public $coolAppCode;

    /**
     * @var string
     */
    public $coolAppName;
    protected $_name = [
        'coolAppCode' => 'coolAppCode',
        'coolAppName' => 'coolAppName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->coolAppName) {
            $res['coolAppName'] = $this->coolAppName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return coolApps
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['coolAppName'])) {
            $model->coolAppName = $map['coolAppName'];
        }

        return $model;
    }
}
