<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateShortcutResponseBody\openDentryInfo;
use AlibabaCloud\Tea\Model;

class CreateShortcutResponseBody extends Model
{
    /**
     * @example dentry
     *
     * @var openDentryInfo
     */
    public $openDentryInfo;
    protected $_name = [
        'openDentryInfo' => 'openDentryInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openDentryInfo) {
            $res['openDentryInfo'] = null !== $this->openDentryInfo ? $this->openDentryInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateShortcutResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openDentryInfo'])) {
            $model->openDentryInfo = openDentryInfo::fromMap($map['openDentryInfo']);
        }

        return $model;
    }
}
