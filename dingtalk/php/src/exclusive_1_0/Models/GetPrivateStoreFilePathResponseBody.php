<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrivateStoreFilePathResponseBody extends Model
{
    /**
     * @var string
     */
    public $filePath;
    protected $_name = [
        'filePath' => 'filePath',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->filePath) {
            $res['filePath'] = $this->filePath;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrivateStoreFilePathResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['filePath'])) {
            $model->filePath = $map['filePath'];
        }

        return $model;
    }
}
