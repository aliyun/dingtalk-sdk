<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetUuidByIdOrUrlResponseBody extends Model
{
    /**
     * @var string
     */
    public $dentryUuid;
    protected $_name = [
        'dentryUuid' => 'dentryUuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUuidByIdOrUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }

        return $model;
    }
}
