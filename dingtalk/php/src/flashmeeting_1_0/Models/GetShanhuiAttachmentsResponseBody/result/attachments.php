<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiAttachmentsResponseBody\result;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @var string
     */
    public $resourceUrl;
    protected $_name = [
        'resourceUrl' => 'resourceUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->resourceUrl) {
            $res['resourceUrl'] = $this->resourceUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachments
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resourceUrl'])) {
            $model->resourceUrl = $map['resourceUrl'];
        }

        return $model;
    }
}
