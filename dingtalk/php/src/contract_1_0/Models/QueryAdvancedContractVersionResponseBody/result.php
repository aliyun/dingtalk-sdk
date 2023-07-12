<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryAdvancedContractVersionResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $enableEsignAttachmentSign;

    /**
     * @var string[]
     */
    public $extension;

    /**
     * @example advanced
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'enableEsignAttachmentSign' => 'enableEsignAttachmentSign',
        'extension'                 => 'extension',
        'version'                   => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableEsignAttachmentSign) {
            $res['enableEsignAttachmentSign'] = $this->enableEsignAttachmentSign;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enableEsignAttachmentSign'])) {
            $model->enableEsignAttachmentSign = $map['enableEsignAttachmentSign'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
