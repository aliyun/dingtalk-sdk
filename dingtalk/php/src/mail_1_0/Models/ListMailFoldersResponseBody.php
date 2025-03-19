<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\ListMailFoldersResponseBody\folders;
use AlibabaCloud\Tea\Model;

class ListMailFoldersResponseBody extends Model
{
    /**
     * @var folders[]
     */
    public $folders;
    protected $_name = [
        'folders' => 'folders',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->folders) {
            $res['folders'] = [];
            if (null !== $this->folders && \is_array($this->folders)) {
                $n = 0;
                foreach ($this->folders as $item) {
                    $res['folders'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListMailFoldersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['folders'])) {
            if (!empty($map['folders'])) {
                $model->folders = [];
                $n = 0;
                foreach ($map['folders'] as $item) {
                    $model->folders[$n++] = null !== $item ? folders::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
