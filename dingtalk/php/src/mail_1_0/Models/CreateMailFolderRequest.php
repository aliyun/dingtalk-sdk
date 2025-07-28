<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateMailFolderRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $displayName;

    /**
     * @var mixed[]
     */
    public $extensions;

    /**
     * @var string
     */
    public $folerId;
    protected $_name = [
        'displayName' => 'displayName',
        'extensions' => 'extensions',
        'folerId' => 'folerId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->extensions) {
            $res['extensions'] = $this->extensions;
        }
        if (null !== $this->folerId) {
            $res['folerId'] = $this->folerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMailFolderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['extensions'])) {
            $model->extensions = $map['extensions'];
        }
        if (isset($map['folerId'])) {
            $model->folerId = $map['folerId'];
        }

        return $model;
    }
}
