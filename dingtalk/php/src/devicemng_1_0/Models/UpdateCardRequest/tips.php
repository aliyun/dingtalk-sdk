<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models\UpdateCardRequest;

use AlibabaCloud\Tea\Model;

class tips extends Model
{
    /**
     * @var string
     */
    public $cids;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $sender;
    protected $_name = [
        'cids'    => 'cids',
        'content' => 'content',
        'sender'  => 'sender',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cids) {
            $res['cids'] = $this->cids;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->sender) {
            $res['sender'] = $this->sender;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tips
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cids'])) {
            $model->cids = $map['cids'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['sender'])) {
            $model->sender = $map['sender'];
        }

        return $model;
    }
}
